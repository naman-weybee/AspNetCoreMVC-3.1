using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.Use(async (context, next) =>
           //{
           //    await context.Response.WriteAsync("Hello From My First Middleware \n");
           //    await next();
           //    await context.Response.WriteAsync("Hello From My First Middleware Response \n");
           //});

           // app.Use(async (context, next) =>
           // {
           //     await context.Response.WriteAsync("Hello From My Second Middleware \n");
           //     await next();
           //     await context.Response.WriteAsync("Hello From My Second Middleware Response \n");
           // });

           // app.Use(async (context, next) =>
           // {
           //     await context.Response.WriteAsync("Hello From My Third Middleware \n");
           //     await next();
           // });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World! \n");
                });
            });
        }
    }
}
