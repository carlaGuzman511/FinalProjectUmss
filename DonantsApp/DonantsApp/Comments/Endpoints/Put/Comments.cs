using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Comments;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DonantsApp.Comments.Endpoints.Put
{
    public class Comments
    {
        private readonly ICommentRepository _commentRepository;
        private readonly ILogger<Comments> _logger;

        public Comments(ILogger<Comments> logger, ICommentRepository commentRepository)
        {
            _logger = logger;
            _commentRepository = commentRepository;
        }

        [Function("UpdateComment")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "put", Route = "comments/{commentId:int}")] HttpRequest req, int commentId)
        {
            bool result = false;
            try
            {
                ICommentService commentService = new CommentService(_commentRepository);
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                Comment c = JsonConvert.DeserializeObject<Comment>(requestBody);
                c.Id = commentId;
                result = await commentService.UpdateCommentAsync(c);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(result);
        }
    }
}
