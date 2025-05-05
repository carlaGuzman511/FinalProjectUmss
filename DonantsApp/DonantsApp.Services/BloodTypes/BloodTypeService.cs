using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;

namespace DonantsApp.Services.BloodTypes
{
    public class BloodTypeService : IBloodTypeService
    {
        internal readonly IBloodTypeRepository _bloodTypeRepository;
        public BloodTypeService(IBloodTypeRepository bloodTypeRepository)
        {
            this._bloodTypeRepository = bloodTypeRepository;
        }

        public async Task<BloodType> GetBloodTypeAsync(int bloodTypeId)
        {
            return await _bloodTypeRepository.GetBloodTypeAsync(bloodTypeId);
        }

        public async Task<IEnumerable<BloodType>> GetBloodTypesAsync()
        {
            return await _bloodTypeRepository.GetBloodTypesAsync();
        }
    }
}
