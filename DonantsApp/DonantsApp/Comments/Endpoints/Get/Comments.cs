using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Comments;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Comments.Endpoints.Get
{
    public class Comments
    {
        private readonly ILogger<Comments> _logger;
        private readonly ICommentRepository _commentRepository;

        public Comments(ILogger<Comments> logger, ICommentRepository commentRepository)
        {
            _logger = logger;
            _commentRepository = commentRepository;
        }

        [Function("GetComments")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "comments/posts/{postId:int}")] HttpRequest req, int postId)
        {
            IEnumerable<Comment> comments = new List<Comment>();
            try
            {
                ICommentService commentService = new CommentService(_commentRepository);
                comments = await commentService.GetCommentsByPostIdAsync(postId);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(comments);
        }
    }
}
