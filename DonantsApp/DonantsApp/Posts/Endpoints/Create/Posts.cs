using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DonantsApp.Posts.Endpoints.Create
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

        [Function("CreatePost")]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post", Route = "posts")] HttpRequest req)
        {
            try
            {
                IPostService postService = new PostService(_postRepository);
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                Post p = JsonConvert.DeserializeObject<Post>(requestBody);
                Post post = await postService.CreatePostAsync(p);

                return new OkObjectResult(post);
            }//todo create our custom errors for handle the error 400
            catch (ValidationException ex)
            {
                _logger.LogError(ex.ToString());
                return new ObjectResult(ex.ToString())
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new ObjectResult(ex.Message)
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                };
            }
        }
    }
}
