using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface IPostTypeService
    {
        Task<IEnumerable<PostType>> GetPostTypesAsync();
        Task<PostType> GetPostTypeAsync(int postTypeId);
    }
}
