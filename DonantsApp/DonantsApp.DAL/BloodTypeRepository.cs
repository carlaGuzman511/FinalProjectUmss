using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;

namespace DonantsApp.DAL
{
    public class BloodTypeRepository : IBloodTypeRepository
    {
        public Task<IEnumerable<BloodType>> GetBloodTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
