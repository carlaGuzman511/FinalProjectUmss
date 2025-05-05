using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface IBloodTypeRepository
    {
        Task<IEnumerable<BloodType>> GetBloodTypesAsync();

        Task<BloodType> GetBloodTypeAsync(int bloodTypeId);
    }
}
