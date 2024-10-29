using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Comments.Endpoints.Delete
{
    public class Comments
    {
        private readonly ILogger<Comments> _logger;

        public Comments(ILogger<Comments> logger)
        {
            _logger = logger;
        }

        [Function("DeleteComment")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "delete", "comments/{commentId}")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
