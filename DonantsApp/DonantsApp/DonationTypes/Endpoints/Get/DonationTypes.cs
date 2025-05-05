using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.DonationTypes;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.DonationTypes.Endpoints.Get
{
    public class DonationTypes
    {
        private readonly ILogger<DonationTypes> _logger;
        private readonly IDonationTypeRepository _donationTypeRepository;
        public DonationTypes(ILogger<DonationTypes> logger, IDonationTypeRepository donationTypeRepository)
        {
            _logger = logger;
            _donationTypeRepository = donationTypeRepository;
        }

        [Function("GetDonationTypes")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "donation-types")] HttpRequest req)
        {
            IEnumerable<DonationType> donationTypes = new List<DonationType>();
            try
            {
                IDonationTypeService donationTypeService = new DonationTypeService(_donationTypeRepository);
                donationTypes = await donationTypeService.GetDonationTypesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(donationTypes);
        }
    }
}
