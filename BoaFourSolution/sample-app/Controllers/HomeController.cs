using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Administrator,Users")] // block the access to any user unless and until he logs in
    public class HomeController : Controller
    {
        private readonly IRandomService _randomService;
        private readonly IRandomWrapper _randomWrapper;
        private readonly IStoreRepository _repository;
        private readonly ILogger<HomeController> _logger;
        private readonly IFileProvider _fileProvider;
        private readonly IMapper _mapper;
        public int PageSize = 3;

        public HomeController(IRandomService randomService, IRandomWrapper randomWrapper,
            IStoreRepository repository, ILogger<HomeController> logger, IFileProvider fileProvider, IMapper mapper)
        {
            _randomService = randomService;
            _randomWrapper = randomWrapper;
            _repository = repository;
            _logger = logger;
            _fileProvider = fileProvider;
            _mapper = mapper;
        }
        // Default Home Page

        // IActionResult is Common Type :  For View, Json , PartialView,
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]

        [AllowAnonymous]
        public IActionResult Index(string category, int productPage = 1)
        {
            _logger.LogInformation($"Index Called : {category} Page No : {productPage}");

            _logger.LogError($"Index Called : {category} Page No : {productPage}");

            _logger.LogWarning($"Index Called : {category} Page No : {productPage}");
            // Product
            var products = _repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize);

            // Pagination
            var PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? _repository.Products.Count() :
                _repository.Products.Where(x => x.Category == category).Count()
            };


            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                PagingInfo = PagingInfo,
                Products = products,
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
        public IActionResult Create(ProductAddViewModel productAddViewModel)
        {



            _logger.LogInformation($"Product Added with ID : {productAddViewModel.ProductId}");
            // All the Data Anotation Rules are proper
            if (ModelState.IsValid)
            {
                // View : ProductAddviewModel ===Converted ==> >  DAL :  Model

                var product = _mapper.Map<Product>(productAddViewModel);
                _repository.AddProduct(product);
                return RedirectToAction("Index", "Home");
            }
            return View();

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
            // Model => Product ..  Converted into ViewModel ..  Update Expects 
            var product = _repository.GetProductById(id);
            var productEditViewModel = _mapper.Map<ProductEditViewModel>(product);           
            return View(productEditViewModel);
        }
        [HttpPost]
        public IActionResult Update(ProductEditViewModel productEditViewModel)
        {
            if (ModelState.IsValid)
            {
                // View : productEditViewModel ===Converted ==> >  DAL :  Model
                var updatedProduct = _mapper.Map<Product>(productEditViewModel);                
                _repository.UpdateProduct(updatedProduct);
                return RedirectToAction("Index", "Home");
            }
            return View();

        }

        // About Us Page
        public IActionResult AboutUs()
        {
           // _repository.PerformTransaction();

            //var product = _repository.GetProductById(1);
            //return View(product);
            //throw new Exception();
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


        // Logic to Validate Category
        public IActionResult VerifyCategory(string category)
        {            // Verify it
            // Any Valid logic  that will check for the existence of data
            if (category == "Chess" || category == "Soccer" || category == "Cricket")
            {
                return Json(true);
            }
            return Json(false);
        }

    }
}
