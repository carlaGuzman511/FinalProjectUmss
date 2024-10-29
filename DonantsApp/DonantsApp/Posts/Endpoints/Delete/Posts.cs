using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DonantsApp.Posts.Endpoints.Delete
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

        [Function("DeletePost")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "delete", Route="posts/{postId:int}")] HttpRequest req, int postId)
        {
            IPostService postService = new PostService(_postRepository);
            await postService.DeletePostAsync(postId);
            return new OkObjectResult(null);
        }
    }
}
