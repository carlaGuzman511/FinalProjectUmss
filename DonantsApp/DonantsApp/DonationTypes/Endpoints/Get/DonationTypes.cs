using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.DonationTypes.Endpoints.Get
{
    public class DonationTypes
    {
        private readonly ILogger<DonationTypes> _logger;

        public DonationTypes(ILogger<DonationTypes> logger)
        {
            _logger = logger;
        }

        [Function("GetDonationTypes")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "donationTypes")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
