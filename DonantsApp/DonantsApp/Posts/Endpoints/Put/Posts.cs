using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DonantsApp.Posts.Endpoints.Put
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

        [Function("UpdatePost")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "put", Route = "posts/{postId:int}")] HttpRequest req, int postId)
        {
            bool result = false;
            try
            {
                IPostService postService = new PostService(_postRepository);
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                Post p = JsonConvert.DeserializeObject<Post>(requestBody);
                p.Id = postId;
                result = await postService.UpdatePostAsync(p);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(result);
        }
    }
}
