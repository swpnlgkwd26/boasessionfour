using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using sample_app.Models;
using sample_app.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomService _randomService;
        private readonly IRandomWrapper _randomWrapper;
        private readonly IStoreRepository _repository;
        private readonly ILogger<HomeController> _logger;
        private readonly IFileProvider _fileProvider;
        public int PageSize = 1;

        public HomeController(IRandomService randomService, IRandomWrapper randomWrapper,
            IStoreRepository repository,ILogger<HomeController> logger,IFileProvider fileProvider)
        {
            _randomService = randomService;
            _randomWrapper = randomWrapper;
            _repository = repository;
            _logger = logger;
            _fileProvider = fileProvider;
        }
        // Default Home Page

        // IActionResult is Common Type :  For View, Json , PartialView,
        public IActionResult Index(string category ,int productPage = 1)
        {
            _logger.LogInformation($"Index Called : {category} Page No : {productPage}");

            _logger.LogError($"Index Called : {category} Page No : {productPage}");

            _logger.LogWarning($"Index Called : {category} Page No : {productPage}");
            // Product
            var products = _repository.Products
                .Where(p=> category == null || p.Category == category)
                .OrderBy(p=>p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize);

            // Pagination
            var PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems =  category == null ? _repository .Products.Count() : 
                _repository.Products.Where(x=>x.Category == category).Count()
            };
            

            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                PagingInfo= PagingInfo,
                Products= products,
                CurrentCategory = category
            };
         
            _logger.LogInformation($"Data PAss to View : {category} Page No : {productPage}");
            return View(productListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {

            _logger.LogInformation($"Product Added with ID : {product.ProductId}");
            _repository.AddProduct(product);
            return RedirectToAction("Index", "Home");
        }

        // Delete Product
        public IActionResult Delete(int id)
        {
            //Delete Logic
            var status = _repository.DeleteProduct(id);
            if (status)
            {
                return RedirectToAction("Index", "Home");
            }
            return Content("Product Cant be Deleted");

        }

        // Return View To update
        public IActionResult Update(int id)
        {

            _logger.LogInformation($"Product AdUpdateded with ID : {id}");
            var product = _repository.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product updatedProduct)
        {
            _repository.UpdateProduct(updatedProduct);
            return RedirectToAction("Index", "Home");
        }

        // About Us Page
        public IActionResult AboutUs(Product product)
        {
            return View();

        }
        // Contact Us Page
        public IActionResult ContactUs()
        {
            var contents = _fileProvider.GetDirectoryContents("KYC");
            return View(contents);
        }

        [HttpPost]
        public IActionResult FileUpload(List<IFormFile> files)
        {
            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "KYC", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
