using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestingMultipleImplementatinOfDi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        private readonly Func<bool, IFileProcessor> _serviceAccessor;

        public MultipleController(Func<bool, IFileProcessor> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        [HttpPost]
        public async Task<ActionResult> PostImage(IFormFile formFile)
        {
            var fileSize = formFile.Length;
            var context = new Context();

            if (fileSize > 100000)
            {
                _serviceAccessor(true);
                context.SetStrategy(new LargeFileProcessor());
                return Ok (context.DoSomeBusinessLogic());
            }
            else
            {
                _serviceAccessor(false);
                context.SetStrategy(new SmallFileProcessor());
                return Ok( context.DoSomeBusinessLogic());
            }
        }
    }
}
