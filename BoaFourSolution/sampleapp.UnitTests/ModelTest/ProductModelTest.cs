using sample_app.Models;
using System;
using Xunit;

namespace sampleapp.UnitTests
{
    public class ProductModelTest
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product
            {
                ProductName = "Product1",
                Price =100
            };
            // Act
            p.ProductName = "Product2";

            // Assert

            Assert.Equal("Product2", p.ProductName);

        }
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product
            {
                ProductName = "Product1",
                Price = 100
            };

            // Act
            p.Price =101;

            // Assert

            Assert.Equal(101, p.Price);
        }
    }
}
