using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrionInnovation.Application;

namespace OrionInnovationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetText()
        {
            return Ok();
        }

        [HttpPost("count_words")]
        public async Task<IActionResult> CountWords([FromBody] CountWordsQuary request)
        {
            var result = await MediatR.Send(request);
            
            return new OkObjectResult(result);
        }
    }
}