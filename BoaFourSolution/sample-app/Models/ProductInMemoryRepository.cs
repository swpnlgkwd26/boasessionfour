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

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
