using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.FileProcessor;
using System.Threading.Tasks;

namespace TestingMultipleImplementatinOfDi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        private readonly IFileProcessor _fileProcessor;
        public MultipleController(IFileProcessor fileProcessor)
        {
            _fileProcessor = fileProcessor;
        }

        [HttpPost]
        public async Task<ActionResult> PostImage(IFormFile formFile)
        {
            var fileSize = formFile.Length;

            if (fileSize > 100000)
            {
                _fileProcessor.ProcessFile(true);
                return Ok ("Process large file");
            }
            else
            {
                _fileProcessor.ProcessFile(false);
                return Ok("Process small file");
            }
        }
    }
}
