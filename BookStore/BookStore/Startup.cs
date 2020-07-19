using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //we can achieve same feature with services.AddControllersWithViews
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //8. Middleware
            //Adding new middleware
            //async because .net core works on async programming
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my first middleware response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my second middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my second middleware response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my third middleware");
            //    //if we use next() here then "Hello World!!" middleware will be executed else not
            //});

            //Default middleware
            app.Run(async (context) =>
            {
          
                await context.Response.WriteAsync("Hello World!");
                //if (env.IsDevelopment())
                //{
                //    await context.Response.WriteAsync("Hello World from dev");
                //}
                //else if (env.IsProduction())
                //{
                //    await context.Response.WriteAsync("Hello World from pro");
                //}
                //else if (env.IsStaging())
                //{
                //    await context.Response.WriteAsync("Hello World from stag");
                //}
                //else
                //{
                //    await context.Response.WriteAsync("Hello World from "+ env.EnvironmentName);
                //}
            });
        }
    }
}
