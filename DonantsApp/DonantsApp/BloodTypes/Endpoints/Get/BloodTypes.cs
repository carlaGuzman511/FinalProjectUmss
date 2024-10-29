using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.BloodTypes.Endpoints.Get
{
    public class BloodTypes
    {
        private readonly ILogger<BloodTypes> _logger;

        public BloodTypes(ILogger<BloodTypes> logger)
        {
            _logger = logger;
        }

        [Function("GetBloodTypes")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "bloodTypes")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
