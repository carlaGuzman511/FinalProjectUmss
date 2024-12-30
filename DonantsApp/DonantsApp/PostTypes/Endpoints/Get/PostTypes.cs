using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.PostTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DonantsApp.PostTypes.Endpoints.Get
{
    public class PostTypes
    {
        private readonly ILogger<PostTypes> _logger;
        private readonly IPostTypeRepository _postTypeRepository;

        public PostTypes(ILogger<PostTypes> logger, IPostTypeRepository postTypeRepository)
        {
            _logger = logger;
            _postTypeRepository = postTypeRepository;
        }

        [Function("GetPostTypes")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "post-types")] HttpRequest req)
        {
            IEnumerable<PostType> postTypes = new List<PostType>();
            try
            {
                IPostTypeService postTypeService = new PostTypeService(_postTypeRepository);
                postTypes = await postTypeService.GetPostTypesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return new OkObjectResult(postTypes);
        }
    }
}
