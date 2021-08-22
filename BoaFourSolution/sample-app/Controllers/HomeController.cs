using Microsoft.AspNetCore.Mvc;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomService _randomService;
        private readonly IRandomWrapper _randomWrapper;
        private readonly IStoreRepository _repository;

        public HomeController(IRandomService randomService, IRandomWrapper randomWrapper,
            IStoreRepository repository)
        {
            _randomService = randomService;
            _randomWrapper = randomWrapper;
            _repository = repository;
        }
        // Default Home Page

        // IActionResult is Common Type :  For View, Json , PartialView,
        public IActionResult Index()
        {
            var products = _repository.Products;
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _repository.AddProduct(product);
            return RedirectToAction("Index", "Home");
        }


        // About Us Page
        public IActionResult AboutUs()
        {
            return View();

        }
        // Contact Us Page
        public IActionResult ContactUs()
        {
            return View();
        }


    }
}
