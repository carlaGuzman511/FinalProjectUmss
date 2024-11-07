using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Models.Enums;
using System.Data;
using System.Data.SqlClient;

namespace DonantsApp.DAL
{
    public class PostRepository : IPostRepository
    {
        internal readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=DonantsApp;Trusted_Connection=True;";
        public async Task<Post> CreatePost(Post post)
        {
            string sp = "SP_CreatePost";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", postId);
                await connection.QuerySingleOrDefaultAsync(
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AccountId", accountId);
                posts = await connection.QueryAsync<Post, Person, DonationType, PostType, Status, Post>(
                    sp,
                    (post, person, donationType, postType, status) =>
                    {
                        post.Account = new Account();
                        post.Account.Person = person;
                        post.DonationType = donationType;
                        post.PostType = postType;
                        post.Status = status;
                        return post;
                    },
                    parameters,
                    splitOn: "FirstName, BloodTypeId, DonationTypeId, PostTypeId, StatusId",
                    commandType: CommandType.StoredProcedure
                );
            }

            return posts;
        }
        public async Task<Post> GetPostByIdAsync(int postId)
        {
            IEnumerable<Post> posts;
            string sp = "SP_GetPosts";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", postId);
                posts = await connection.QueryAsync<Post, Person, DonationType, PostType, Status, Post>(
                    sp,
                    (post, person, donationType, postType, status) =>
                    {
                        post.Account = new Account();
                        post.Account.Person = person;
                        post.DonationType = donationType;
                        post.PostType = postType;
                        post.Status = status;
                        return post;
                    },
                    parameters,
                    splitOn: "FirstName, BloodTypeId, DonationTypeId, StatusId",
                    commandType: CommandType.StoredProcedure
                );
            }

            return posts.First();
        }
        public async Task<Post> UpdatePostAsync(Post post)
        {
            string sp = "SP_UpdatePost";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", post.Title);
                parameters.Add("@Description", post.Description);
                parameters.Add("@DonationTypeId", post.DonationType);
                parameters.Add("@StatusId", post.Status);
                parameters.Add("@PostTypeId", post.PostType);
                parameters.Add("@AccountId", post.Account);
                parameters.Add("@Image", post.Image);
                parameters.Add("@PostId", post.Id);
                await connection.QuerySingleOrDefaultAsync<int>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
            return post;
        }
    }
}
