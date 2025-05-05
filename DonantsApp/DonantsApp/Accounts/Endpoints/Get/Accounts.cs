using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.Accounts.Endpoints.Get
{
    public class Accounts
    {
        private readonly ILogger<Accounts> _logger;

        public Accounts(ILogger<Accounts> logger)
        {
            _logger = logger;
        }

        [Function("GetAccounts")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "accounts")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
