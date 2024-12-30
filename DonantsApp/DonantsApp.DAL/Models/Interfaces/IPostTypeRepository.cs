using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface IPostTypeRepository
    {
        Task<IEnumerable<PostType>> GetPostTypesAsync();
        Task<PostType> GetPostTypeAsync(int postTypeId);
    }
}
