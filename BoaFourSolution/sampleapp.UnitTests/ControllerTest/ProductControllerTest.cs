using Microsoft.AspNetCore.Mvc;
using Moq;
using sample_app.Controllers;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace sampleapp.UnitTests.ControllerTest
{
    public class ProductControllerTest
    {
        [Fact]
        public void Can_UseRepository()
        {
            // Arrange
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Products)
                .Returns(new Product[]{
                      new Product{ ProductId =1 ,ProductName = "P1"},
                      new Product{ ProductId =2 ,ProductName = "P2"}
                    });
            ProductController controller = new ProductController(mock.Object);
            // Act
            IEnumerable<Product> result =  
                (controller.Index() as ViewResult).ViewData.Model as IEnumerable<Product>;

            // Assert
            Product[] prodArray = result.ToArray();
            Assert.Equal("P1", prodArray[0].ProductName);
            Assert.Equal("P2", prodArray[1].ProductName);
        }

        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Products)
                .Returns(new Product[]{
                      new Product{ ProductId =1 ,ProductName = "P1"},
                      new Product{ ProductId =2 ,ProductName = "P2"},
                        new Product{ ProductId =3 ,ProductName = "P3"},
                      new Product{ ProductId =4 ,ProductName = "P4"},
                        new Product{ ProductId =5 ,ProductName = "P5"},
                      new Product{ ProductId =6 ,ProductName = "P6"}

                    });
            ProductController controller = new ProductController(mock.Object);

            // Act
            IEnumerable<Product> result =
                (controller.IndexwithPagination(2) as ViewResult).ViewData.Model as IEnumerable<Product>;

            // Assert

            Product[] prodArray = result.ToArray();
            Assert.Equal("P3", prodArray[0].ProductName);
            Assert.Equal("P4", prodArray[1].ProductName);

        }
    }
}
