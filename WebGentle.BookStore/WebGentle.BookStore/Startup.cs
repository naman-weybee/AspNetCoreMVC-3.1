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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

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

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        if (env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("Hello From Development !");
            //        }
            //        else if (env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("Hello From Production !");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("Hello From Staging !");
            //        }
            //        else if (env.IsEnvironment("Custom"))
            //        {
            //            await context.Response.WriteAsync("Hello From Custom Name !");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync(env.EnvironmentName);
            //        }
            //    });
            //});
        }
    }
}
