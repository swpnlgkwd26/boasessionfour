using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Infrastructure
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            // Read the querystring 
            var culture = context.Request.Query["culture"];
            if (!string.IsNullOrEmpty(culture))
            {
                // Convert it  into Culture information
                var cultureInfo = new CultureInfo(culture);
                CultureInfo.CurrentCulture = cultureInfo;
            }
            await _next(context);          
        }
    }
}
