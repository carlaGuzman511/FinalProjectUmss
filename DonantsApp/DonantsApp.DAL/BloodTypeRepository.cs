using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class BloodTypeRepository : IBloodTypeRepository
    {
        private readonly string _connectionString;
        public BloodTypeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<BloodType> GetBloodTypeAsync(int bloodTypeId)
        {
            BloodType bloodType;
            string sp = "SP_GetBloodTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BloodTypeId", bloodTypeId);
                bloodType = await connection.QuerySingleAsync<BloodType>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return bloodType;
        }

        public async Task<IEnumerable<BloodType>> GetBloodTypesAsync()
        {

            IEnumerable<BloodType> bloodTypes;
            string sp = "SP_GetBloodTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                bloodTypes = await connection.QueryAsync<BloodType>(
                    sp,
                    commandType: CommandType.StoredProcedure
                );
            }

            return bloodTypes;
        }
    }
}
