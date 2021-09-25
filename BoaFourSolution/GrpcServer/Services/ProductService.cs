using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class ProductService : Product.ProductBase
    {
        // Server Streaming :   Single Request Multiple Response
        public async override Task GetProducts(EmptyProductModel request, IServerStreamWriter<ProductModel> responseStream,
            ServerCallContext context)
        {
            // Data : Assuming comming from db
            List<ProductModel> productModels = new List<ProductModel>
            {
                new ProductModel
                {
                    ProductId=1,Price=10,ProductName="IPhone",Category="Electronics",Description="IPhone"
                },
                new ProductModel
                {
                    ProductId=2,Price=10,ProductName="Samsung",Category="Electronics",Description="IPhone"
                }
            };
            foreach (var item in productModels)
            {
                await Task.Delay(3000);
                await responseStream.WriteAsync(item);
            }
        }

        // Unary
        public override Task<ProductModel> GetProductById(ProductLookModel request, ServerCallContext context)
        {
            var product1 = new ProductModel
            {
                ProductId = 1,
                Price = 10,
                ProductName = "IPhone",
                Category = "Electronics",
                Description = "IPhone"
            };

            var product2 = new ProductModel
            {
                ProductId = 2,
                Price = 10,
                ProductName = "Samsung",
                Category = "Electronics",
                Description = "IPhone"
            };

            var output = new ProductModel();

            ProductModel productModel = new ProductModel();
            if (request.ProductId ==1)
            {
                output = product1;
                
            }
            else if (request.ProductId == 2)
            {
                output = product2;
                
            }
            return Task.FromResult(output);
        }
    }
}
