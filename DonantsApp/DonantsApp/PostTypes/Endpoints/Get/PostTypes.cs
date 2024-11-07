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
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "postTypes")] HttpRequest req)
        {
            IPostTypeService postTypeService = new PostTypeService(_postTypeRepository);
            IEnumerable<PostType> postTypes = await postTypeService.GetPostTypesAsync();

            return new OkObjectResult(postTypes);
        }
    }
}
