﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Platform.Services;
namespace Platform
{
    public class WeatherMiddleware
    {
        private RequestDelegate next; 
        //private IResponseFormatter formatter;
        public WeatherMiddleware(RequestDelegate nextDelegate)
        {
            
            next = nextDelegate;
        }
        public async Task Invoke(HttpContext context, IResponseFormatter formatter)
        {
            if (context.Request.Path == "/middleware/class")
            {
                await formatter.Format(context,
                            "Middleware Class: It is raining in London");
            }
            else
            {
                await next(context);
            }
        }
    }
}