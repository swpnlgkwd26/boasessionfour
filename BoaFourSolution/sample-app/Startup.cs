using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using sample_app.Models;
using System;
using System.Collections.Generic;
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
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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


            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Routing Logic
                // Default Controller Name : Home and Action Name = Index
                // http://localhost/home/index
                endpoints.MapDefaultControllerRoute();           

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Short Circuiting");
            });


        }
    }
}