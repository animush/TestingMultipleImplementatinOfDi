using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace TestingMultipleImplementatinOfDi
{
    public class FileProcessingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Func<bool, IFileProcessor> _serviceAccessor;

        public FileProcessingMiddleware(RequestDelegate next, Func<bool, IFileProcessor> serviceAccessor)
        {
            _next = next;
            _serviceAccessor = serviceAccessor;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var fileSize = context.Request.ContentLength ?? 0;

            if (fileSize > 100000)
            {
                _serviceAccessor(true);
            }
            else
            {
                _serviceAccessor(false);
            }

            await _next(context);
        }
    }
}
