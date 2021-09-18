using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample_webapi.Filters;
using sample_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly BoaSessionFourSatContext _context;

        public ProductsController(BoaSessionFourSatContext context)
        {
            _context = context;
        }

        [HttpGet]
        // Capable of Returning Data in JSON and XML format
        [Produces("application/json","application/xml")]
        public IAsyncEnumerable<Product> GetProduct()
        {
            return _context.Products;
        }
        [HttpGet("{id}")]
        // Capable of Returning Data in JSON 
        [Produces("application/json")]
        // IT can Return 200 Or 404 Not Found : OP will appear in Swagger
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProductById(int id)
        {
            Product p = await _context.Products.FindAsync(id);
            if (p == null)
            {
                return NotFound();
            }
            // return Ok(new { ProductId = p.ProductId,Name=p.ProductName,Category=p.Category});
            return Ok(p);
        }
        [HttpPost]
        // Accept Data only in JSON format
         [Consumes("application/json")]
         [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [CustomActionFilter]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {           
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id)
        {
            var product = _context.Products.Single(x => x.ProductId == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        [HttpPut]
        [Consumes("application/json", "application/xml")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [CustomActionFilter]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }

}

