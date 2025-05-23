using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Comments;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DonantsApp.Comments.Endpoints.Create
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

        [Function("CreateComment")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "comments")] HttpRequest req)
        {
            Comment comment = null;
            try
            {
                ICommentService commentService = new CommentService(_commentRepository);
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                Comment c = JsonConvert.DeserializeObject<Comment>(requestBody);
                comment = await commentService.CreateCommentAsync(c);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(comment);
        }
    }
}
