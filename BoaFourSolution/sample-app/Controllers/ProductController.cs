using Microsoft.AspNetCore.Mvc;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly IStoreRepository repository;
        int PageSize = 2;

        public ProductController(IStoreRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }

        public IActionResult IndexwithPagination(int productPage)
        {
            return View(repository.Products
                .OrderBy(p => p.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize));
        }
    }
}
