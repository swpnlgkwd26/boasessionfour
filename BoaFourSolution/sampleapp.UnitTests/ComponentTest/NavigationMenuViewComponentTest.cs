using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using sample_app.Components;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace sampleapp.UnitTests.ComponentTest
{
    public class NavigationMenuViewComponentTest
    {
        [Fact]
        public void Check_Navigation()
        {
            // Arrange
            string categoryToSelect = "Cricket";  
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Products)
                .Returns(new Product[]{
                      new Product{ ProductId =1 ,ProductName = "P1"},
                      new Product{ ProductId =2 ,ProductName = "P2"}
                    });

            NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);
            target.ViewComponentContext = new Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponentContext
            {
                ViewContext = new Microsoft.AspNetCore.Mvc.Rendering.ViewContext
                {
                    RouteData = new Microsoft.AspNetCore.Routing.RouteData()
                }
            };
            target.RouteData.Values["category"] = categoryToSelect;// Added the Category to Route Data
            // Act
            string result = (string)(target.Invoke() as ViewViewComponentResult).ViewData["SelectedCategory"];

            // Assert
            Assert.Equal(categoryToSelect, result);
        }
    }
}
