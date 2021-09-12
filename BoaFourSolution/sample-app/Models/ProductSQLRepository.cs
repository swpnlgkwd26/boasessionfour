using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public class ProductSQLRepository : IStoreRepository
    {
        private readonly BoaSessionFourBatchContext _context;

        public ProductSQLRepository(BoaSessionFourBatchContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products => _context.Products;

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public bool DeleteProduct(int id)
        {

            var product = _context.Products.Single(x => x.ProductId == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public Product GetProductById(int id)
        {
            // Stored Procedure
            var product = _context.Products.FromSqlRaw($"RetrieveProductRecord {id}").AsEnumerable();
            return product.FirstOrDefault();
        }

        public void PerformTransaction()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    var inventory = _context.Inventories.Single(p => p.ProductId == 2);
                    inventory.Quantity = inventory.Quantity - 1;
                    _context.SaveChanges();

                    // Error
                    _context.Sales.Add(new Sale
                    {
                        ProductId = 2,
                        ProductName = "samsung"
                    });
                    _context.SaveChanges();                    

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }

            }
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = _context.Products.Single(x => x.ProductId == product.ProductId);
            // Update the Values
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.Price = product.Price;
            productToUpdate.Category = product.Category;
            productToUpdate.Description = product.Description;
            _context.SaveChanges();

        }
    }
}
