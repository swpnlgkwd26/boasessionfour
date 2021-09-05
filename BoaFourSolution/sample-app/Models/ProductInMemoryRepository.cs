using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public class ProductInMemoryRepository : IStoreRepository
    {
        static List<Product> products = new List<Product>
        {
            new Product
            {
                ProductId=1,ProductName="Ball" ,Category="Cricket", Description="Cricket",Price=100
            },
             new Product
            {
                 ProductId=2,ProductName="Bat" ,Category="Cricket", Description="Cricket",Price=200
            },
              new Product
            {
                  ProductId=3,ProductName="Chess Board" ,Category="Chess", Description="Chess",Price=100
            },
               new Product
            {
                   ProductId=4,ProductName="Soccer Ball" ,Category="Soccer", Description="Soccer",Price=100
            }

        };

        // Get All Products
        public IEnumerable<Product> Products => products;

        // Model
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool DeleteProduct(int id)
        {
            // Find the Product to be deleted
            var product = products.Single(x => x.ProductId == id);
            // Delete the Product
            products.Remove(product);
            return true;
        }

        public Product GetProductById(int id)
        {
            return products.Single(x => x.ProductId == id);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            // Get the Product first
            var product = products.Single(x => x.ProductId == updatedProduct.ProductId);
            // Update the Values
            product.ProductName = updatedProduct.ProductName;
            product.Price = updatedProduct.Price;
            product.Category = updatedProduct.Category;
            product.Description = updatedProduct.Description;          

        }
    }
}
