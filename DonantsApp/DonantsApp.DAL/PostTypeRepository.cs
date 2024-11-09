using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class PostTypeRepository : IPostTypeRepository
    {
        private readonly string _connectionString;
        public PostTypeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<PostType> GetPostTypeAsync(int postTypeId)
        {
            PostType postType;
            string sp = "SP_GetPostTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostTypeId", postTypeId);
                postType = await connection.QuerySingleAsync<PostType>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return postType;
        }

        public async Task<IEnumerable<PostType>> GetPostTypesAsync()
        {
            IEnumerable<PostType> postTypes;
            string sp = "SP_GetPostTypes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                postTypes = await connection.QueryAsync<PostType>(
                    sp,
                    commandType: CommandType.StoredProcedure
                );
            }

            return postTypes;
        }
    }
}
