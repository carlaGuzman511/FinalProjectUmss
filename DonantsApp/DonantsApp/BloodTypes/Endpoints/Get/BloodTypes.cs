using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.BloodTypes;
using DonantsApp.Services.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.BloodTypes.Endpoints.Get
{
    public class PostTypes
    {
        private readonly ILogger<PostTypes> _logger;
        private readonly IBloodTypeRepository _bloodTypeRepository;

        public PostTypes(ILogger<PostTypes> logger, IBloodTypeRepository bloodTypeRepository)
        {
            _logger = logger;
            _bloodTypeRepository = bloodTypeRepository;
        }

        [Function("GetBloodTypes")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "bloodTypes")] HttpRequest req)
        {
            IBloodTypeService bloodTypeService = new BloodTypeService(_bloodTypeRepository);
            IEnumerable<BloodType> bloodTypes = await bloodTypeService.GetBloodTypesAsync();

            return new OkObjectResult(bloodTypes);
        }
    }
}
