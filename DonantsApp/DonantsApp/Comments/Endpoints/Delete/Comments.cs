using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Services.Comments;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Comments.Endpoints.Delete
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

        [Function("DeleteComment")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "delete", Route = "comments/{commentId:int}")] HttpRequest req, int commentId)
        {
            bool answer = false;
            try
            {
                ICommentService commentService = new CommentService(_commentRepository);
                answer = await commentService.DeleteCommentAsync(commentId);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(answer);
        }
    }
}
