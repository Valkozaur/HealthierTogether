using HealthierTogether.Server.Infrastructure.Extensions;
using HealthierTogether.Server.Models.Post;
using HealthierTogether.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthierTogether.Server.Controllers
{
    public class PostController : ApiController
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePostModel model)
        {
            if (!ModelState.IsValid)
                return this.BadRequest(ModelState.Values);

            var userId = this.User.GetIdentifier();

            var post = this.postService.CreatePost(model.Name, model.Content, userId);



            return Ok();
        }
    }
}
