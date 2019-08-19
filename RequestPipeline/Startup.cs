﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RequestPipeline.Extensions;
using RequestPipeline.Middlewares;

namespace RequestPipeline
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div>Hello</div>");
                await next.Invoke();
                await context.Response.WriteAsync("<div>Return 1</div>");
            }
            );

            app.UseSimpleMiddleware();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World from the Middleware 1!");
            });
        }

        private Func<RequestDelegate, RequestDelegate> async(object context, object next)
        {
            throw new NotImplementedException();
        }
    }
}
