using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sample_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample_webapi.IntegrationTests
{
   public class TestWebFactory<T> : WebApplicationFactory<Startup>
    {
        // Create Infra for Working with DB .. In memory
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // Infra So  that i can communicate with db using DataContext
            builder.ConfigureServices(services =>
            {
                var description = services.SingleOrDefault(d => d.ServiceType 
                == typeof(DbContextOptions<BoaSessionFourSatContext>));
                if (description !=null)
                {
                    services.Remove(description);
                }

                // Add Service
                var serviceProvider = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();

                // Adding Context
                services.AddDbContext<BoaSessionFourSatContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryProductDB");
                });

            });
            base.ConfigureWebHost(builder);
        }
    }
}
