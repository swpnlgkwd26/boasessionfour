using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static  async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var productClient = new Product.ProductClient(channel);
            using (var call = productClient.GetProducts(new EmptyProductModel()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentProduct = call.ResponseStream.Current;
                    Console.WriteLine(currentProduct.ProductName);
                }

            }

            var result =await productClient.GetProductByIdAsync(new ProductLookModel { ProductId = 1 });

            Console.WriteLine(result.ProductName + " " + result.Price );


            var reply2 =  await client.SayByeAsync(new EmptyModel());
            Console.WriteLine(reply2.Reply);

            var reply = await client.SayHelloAsync(new HelloRequest
            {
                Name = "Ankit"
            });
            Console.WriteLine(reply.Message);

            Console.ReadLine();

        }
    }
}
