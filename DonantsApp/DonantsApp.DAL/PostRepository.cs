using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace DonantsApp.DAL
{
    public class PostRepository : IPostRepository
    {
        internal readonly string _connectionString;
        public PostRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<Post> CreatePost(Post post)
        {
            string sp = "SP_CreatePost";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", post.Title);
                parameters.Add("@Description", post.Description);
                parameters.Add("@Image", post.Image);
                parameters.Add("@DonationTypeId", post.DonationTypeId);
                parameters.Add("@PostTypeId", post.PostTypeId);
                parameters.Add("@AccountId", post.AccountId);
                int id = await connection.QuerySingleAsync<int>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
                post.Id = id;
            }
         
            return post;
        }
        public async Task DeletePostAsync(int postId)
        {
            string sp = "SP_DeletePost";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", postId);
                await connection.QueryAsync(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        public async Task<IEnumerable<Post>> GetPostsAsync(int? accountId = null)
        {
            IEnumerable<Post> posts;
            string sp = "SP_GetPosts";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AccountId", accountId);
                posts = await connection.QueryAsync<Post>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return posts;
        }
        public async Task<Post> GetPostByIdAsync(int postId)
        {
            Post post = null;
            string sp = "SP_GetPosts";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", postId);
                post = await connection.QuerySingleAsync<Post>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return post;
        }
        public async Task UpdatePostAsync(Post post)
        {
            string sp = "SP_UpdatePost";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", post.Title);
                parameters.Add("@Description", post.Description);
                parameters.Add("@DonationTypeId", post.DonationTypeId);
                parameters.Add("@StatusId", post.StatusId);
                parameters.Add("@PostTypeId", post.PostTypeId);
                parameters.Add("@AccountId", post.AccountId);
                parameters.Add("@Image", post.Image);
                parameters.Add("@PostId", post.Id);
                await connection.QueryAsync(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}
