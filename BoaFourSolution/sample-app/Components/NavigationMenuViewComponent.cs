using Microsoft.AspNetCore.Mvc;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Components
{
    // Links  and business logic
    public class NavigationMenuViewComponent :ViewComponent
    {
        private readonly IStoreRepository _repository;

        // Connect DB and Get Categories
        public NavigationMenuViewComponent(IStoreRepository repository)
        {
            _repository = repository;
        }
        // Invoke Method : Automatically called
        public IViewComponentResult Invoke()
        {
            // Get all Categories
            var categories = _repository.Products.Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            // Pass it to View
            return View(categories);

        }
    }
}
