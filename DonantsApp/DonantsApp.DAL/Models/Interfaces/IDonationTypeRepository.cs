using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface IDonationTypeRepository
    {
        Task<IEnumerable<DonationType>> GetDonationTypesAsync();
        Task<DonationType> GetDonationTypeAsync(int donationTypeId);
    }
}
