using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.ViewModels
{
    public class ProductAddViewModel
    {
        [Required(ErrorMessage = "Product ID is Required Field")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required Field")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Description is Required Field")]
        [Display(Name = "Description of the Product")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product Price is Required Field")]
        [Range(0, 999)]
       // [Compare]
        public int Price { get; set; }

        [Required(ErrorMessage = "Product Category is Required Field")]

        // Logic : Server side
        [Remote(action:"VerifyCategory",controller:"Home")]
        public string Category { get; set; }
    }
}
