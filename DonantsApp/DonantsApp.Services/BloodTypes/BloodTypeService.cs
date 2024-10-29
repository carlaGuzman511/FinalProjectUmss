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
        public Task<IEnumerable<BloodType>> GetBloodTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
