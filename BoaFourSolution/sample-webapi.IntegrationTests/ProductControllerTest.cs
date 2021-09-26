using Newtonsoft.Json;
using sample_webapi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace sample_webapi.IntegrationTests
{
    public class ProductControllerTest : IClassFixture<TestWebFactory<Startup>>
    {
        // Test APIS
        private readonly HttpClient _client;
        public ProductControllerTest(TestWebFactory<Startup> factory)
        {
            // Add some mock Product by calling Add API method in In memory product db.
            _client = factory.CreateClient();
            Product product = new Product
            {
                ProductId = 0,
                ProductName = "Product1",
                Category = "Category1",
                Description = "Description1",
                Price = 100
            };
            // product :  byteArrayContent
            var content = JsonConvert.SerializeObject(product);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = _client.PostAsync("/api/products", byteContent).Result;
            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task Check_GetProducts()
        {
            var response = await _client.GetAsync("/api/products");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
          //  Assert.Contains("Product1", responseString);

            var products = JsonConvert.DeserializeObject<Product[]>(responseString);
            Assert.Equal("Product1", products[0].ProductName);
        }
    }
}
