using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string  ProductName { get; set; }
        [Required]
        public string  Description { get; set; }
        [Required]
        [Range(1,999)]
        public int  Price { get; set; }
        [Required]
        public string  Category { get; set; }
    }
}
