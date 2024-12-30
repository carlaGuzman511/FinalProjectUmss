using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;

namespace DonantsApp.Services.DonationTypes
{
    public class DonationTypeService : IDonationTypeService
    {
        internal readonly IDonationTypeRepository _donationTypeRepository;
        public DonationTypeService(IDonationTypeRepository donationTypeRepository)
        {
            this._donationTypeRepository = donationTypeRepository;
        }
        public async Task<DonationType> GetDonationTypeAsync(int donationTypeId)
        {
            return await this._donationTypeRepository.GetDonationTypeAsync(donationTypeId);
        }
        public async Task<IEnumerable<DonationType>> GetDonationTypesAsync()
        {
            return await this._donationTypeRepository.GetDonationTypesAsync();
        }
    }
}