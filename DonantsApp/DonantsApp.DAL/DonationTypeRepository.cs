using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class DonationTypeRepository : IDonationTypeRepository
    {
        private readonly string _connectionString;
        public DonationTypeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<DonationType> GetDonationTypeAsync(int donationTypeId)
        {
            DonationType donationType;
            string sp = "SP_GetDonationTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@DonationTypeId", donationTypeId);
                donationType = await connection.QuerySingleAsync<DonationType>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return donationType;
        }

        public async Task<IEnumerable<DonationType>> GetDonationTypesAsync()
        {
            IEnumerable<DonationType> donationTypes;
            string sp = "SP_GetDonationTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                donationTypes = await connection.QueryAsync<DonationType>(
                    sp,
                    commandType: CommandType.StoredProcedure
                );
            }

            return donationTypes;
        }
    }
}
