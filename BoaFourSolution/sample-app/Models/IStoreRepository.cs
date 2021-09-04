using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public interface IStoreRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
        bool DeleteProduct(int id);
        Product GetProductById(int id);
        void UpdateProduct(Product product);
    }
}
