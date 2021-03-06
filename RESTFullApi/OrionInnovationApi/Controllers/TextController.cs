using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrionInnovation.Application;

namespace OrionInnovationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : BaseController
    {
        [HttpGet("{id}/from_db")]
        [ProducesResponseType(typeof(TextViewModel), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetTextFromDb(int id)
        {
            var text = await MediatR.Send(new GetTextFromDbQuary { Id = id});

            return Ok(text);
        }

        [HttpGet("{id}/from_file_system")]
        [ProducesResponseType(typeof(TextViewModel), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetTextFromFileSystem(int id)
        {
             var text = await MediatR.Send(new GetTextFromFileSystemQuery{ Id = id});

            return Ok(text);
        }

        [HttpPost("count_words")]
        [ProducesResponseType(typeof(CountWordsViewModel), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> CountWords([FromBody] CountWordsQuary request)
        {
            var result = await MediatR.Send(request);
            
            return new OkObjectResult(result);
        }
    }
}