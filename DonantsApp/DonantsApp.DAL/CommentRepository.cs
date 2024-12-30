using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class CommentRepository : ICommentRepository
    {
        private readonly string _connectionString;
        public CommentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<Comment> CreateCommentAsync (Comment comment)
        {
            string sp = "SP_CreateComment";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", comment.PostId);
                parameters.Add("@Description", comment.Description);
                var (id, dateadded) = await connection.QuerySingleAsync<(int, DateTime)>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
                comment.Id = id;
                comment.DateAdded = dateadded;
            }

            return comment;
        }
        public async Task DeleteCommentAsync (int commentId)
        {
            string sp = "SP_DeleteCommentById";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", commentId);
                await connection.QuerySingleOrDefaultAsync(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task<Comment> GetCommentByIdAsync(int commentId)
        {
            Comment comment = null;
            string sp = "SP_GetCommentById";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", commentId);
                comment = await connection.QuerySingleAsync<Comment>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return comment;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
            IEnumerable<Comment> comments;
            string sp = "SP_GetCommentsByPostId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", postId);
                comments = await connection.QueryAsync<Comment>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }

            return comments;
        }

        public async Task UpdateCommentAsync (Comment comment)
        {
            string sp = "SP_UpdateComment";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", comment.Id);
                parameters.Add("@Description", comment.Description);
                await connection.QuerySingleOrDefaultAsync<DateTime>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}
