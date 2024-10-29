using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface IBloodTypeService
    {
        Task<IEnumerable<BloodType>> GetBloodTypesAsync();
    }
}
