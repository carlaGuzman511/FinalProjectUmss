using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class PostTypeRepository : IPostTypeRepository
    {
        internal readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=DonantsApp;Trusted_Connection=True;";
        public async Task<PostType> GetPostTypeAsync(int postTypeId)
        {
            PostType postType;
            string sp = "SP_GetPostTypes";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
