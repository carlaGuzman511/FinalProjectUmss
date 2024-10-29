using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;

namespace DonantsApp.Services.PostTypes
{
    public class PostTypeService : IPostTypeService
    {
        internal readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=DonantsApp;Trusted_Connection=True;";
        internal readonly IPostTypeRepository _postTypeRepository;
        public PostTypeService(IPostTypeRepository postTypeRepository)
        {
            this._postTypeRepository = postTypeRepository;
        }
        public async Task<PostType> GetPostTypeAsync(int postTypeId)
        {
            return await this._postTypeRepository.GetPostTypeAsync(postTypeId);
        }

        public async Task<IEnumerable<PostType>> GetPostTypesAsync()
        {
            return await this.GetPostTypesAsync();
        }
    }
}