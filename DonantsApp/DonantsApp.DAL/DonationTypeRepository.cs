using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class DonationTypeRepository : IDonationTypeRepository
    {
        internal readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=DonantsApp;Trusted_Connection=True;";
        public async Task<DonationType> GetDonationTypeAsync(int donationTypeId)
        {
            DonationType donationType;
            string sp = "SP_GetDonationTypes";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
