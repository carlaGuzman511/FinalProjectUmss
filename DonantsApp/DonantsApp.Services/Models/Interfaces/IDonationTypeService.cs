using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface IDonationTypeService
    {
        Task<IEnumerable<DonationType>> GetDonationTypesAsync();
        Task<DonationType> GetDonationTypeAsync(int donationTypeId);
    }
}
