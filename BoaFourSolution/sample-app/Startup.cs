using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using sample_app.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app
{
    // Thin and Slim that its more performant than any other ASP.Net Tech use to Exist
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
           services.AddControllersWithViews(); // Add all the Service required to understand controller      

            services.AddScoped<IRandomService, RandomService>();
            services.AddScoped<IRandomWrapper, RandomWrapperService>();

            services.AddScoped<IStoreRepository, ProductInMemoryRepository>();

            IFileProvider physicalFileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
            services.AddSingleton<IFileProvider>(physicalFileProvider);

            // Configure Automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsProduction() || env.IsStaging() )
            {
                app.UseExceptionHandler("/error");
            }
            // Serve Static Files :  HTML, CSS and JS to Requester
            // Special Folder :  wwwroot        
            app.UseStaticFiles();

            // Serve Static files from Custom Folder
            app.UseStaticFiles(new StaticFileOptions
            {
                // env  :  Current Environment: Development Production Or Staging
                // ContentRotPath : Absolute path of direc that contains application files
                //FileProvider = new PhysicalFileProvider(env.ContentRootPath + "/myfolder"),
                FileProvider = new PhysicalFileProvider($"{env.ContentRootPath}/myfolder"),
                RequestPath = "/files"
            });




            //-	It looks for the set of defined endpoints and select best match based on the request.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/authorize/{username:minlength(4)}", async context =>
                {
                    // read this route price
                    var userName = context.Request.RouteValues["username"];
                    await context.Response.WriteAsync("Hello : " + userName);
                });

                endpoints.MapGet("/productinfo/{price:int}", async context =>
                {
                    // read this route price
                    var price = context.Request.RouteValues["price"];
                    await context.Response.WriteAsync("Hello : " + price);
                });

                Route / Chess / Page2
                endpoints.MapControllerRoute("catpage", "{category}/Page{productPage:int:min(1)}",
                    new { controller = "Home", action = "Index", productPage = 1 });

                // Route : http://localhost:5000/Cricket

                endpoints.MapControllerRoute("cateogry", "{category}",
                    new { controller = "Home", action = "Index", productPage = 1 });
                //Product/Page3
                endpoints.MapControllerRoute("pagination", "Product/Page{productPage}",
                    new { controller = "Home", action = "Index" });

                // Routing Logic
                // Default Controller Name : Home and Action Name = Index
                // http://localhost/home/index
                endpoints.MapDefaultControllerRoute();           

                

            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Short Circuiting");
            });


        }
    }
}
