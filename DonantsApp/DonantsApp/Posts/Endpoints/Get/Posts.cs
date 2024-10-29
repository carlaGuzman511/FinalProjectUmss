using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Posts.Endpoints.Get
{
    public class Posts
    {
        private readonly ILogger<Posts> _logger;
        private readonly IPostRepository _postRepository;

        public Posts(ILogger<Posts> logger, IPostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        [Function("GetPosts")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "posts")] HttpRequest req)
        {
            IPostService postService = new PostService(_postRepository);
            IEnumerable<Post> posts = await postService.GetPostsAsync();
            return new OkObjectResult(posts);
        }
    }
}
