using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Comments.Endpoints.Create
{
    public class Comments
    {
        private readonly ILogger<Comments> _logger;

        public Comments(ILogger<Comments> logger)
        {
            _logger = logger;
        }

        [Function("CreateComment")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", "comments")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
