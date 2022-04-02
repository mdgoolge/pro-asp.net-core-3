using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Routing;
using Platform.Services;
using Microsoft.Extensions.Configuration;

namespace Platform
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(ICollection<>), typeof(List<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        //        IOptions<MessageOptions>msgOptions)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints=> {
                endpoints.MapGet("/string", async context =>
                 {
                     ICollection<string> collection
                        = context.RequestServices.GetService<ICollection<string>>();
                     collection.Add($"Request:{DateTime.Now.ToLongTimeString()}");
                     foreach (string str in collection)
                     {
                         await context.Response.WriteAsync($"String:{str}\n");
                     }
                 });

                endpoints.MapGet("/int", async context => {
                    ICollection<int> collection
                    = context.RequestServices.GetService<ICollection<int>>();
                    collection.Add(collection.Count() + 1);
                    foreach (int val in collection)
                    {
                        await context.Response.WriteAsync($"Int: {val}\n");
                    }
                });


            });
        }
    }
}
