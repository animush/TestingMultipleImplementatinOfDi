using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestingMultipleImplementatinOfDi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        [HttpPost]
        public async Task<string> PostImage(IFormFile formFile)
        {
            return "Some result";
        }
    }
}
