using HttpClientExample.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpClientExample.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("GetPost/{id}")]
        public async Task<ActionResult> GetPost(int id)
        {
            return Ok(await _postService.GetPost(id));
        }
    }
}
