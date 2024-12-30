using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Posts.Endpoints.Delete
{
    public class Accounts
    {
        private readonly ILogger<Accounts> _logger;

        public Accounts(ILogger<Accounts> logger)
        {
            _logger = logger;
        }

        [Function("DeleteAccount")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "delete", "accounts/{accountId}")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
