using Dapper;
using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace DonantsApp.DAL
{
    public class CommentRepository : ICommentRepository
    {
        internal readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=DonantsApp;Trusted_Connection=True;";

        public async Task<Comment> CreateComment(Comment comment)
        {
            string sp = "SP_CreateComment";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@PostId", comment.PostId);
                parameters.Add("@Description", comment.Description);
                int id = await connection.QuerySingleAsync<int>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
                comment.Id = id;
            }
            return comment;
        }
        public async Task<bool> DeleteComment(int commentId)
        {
            string sp = "SP_DeleteCommentById";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", commentId);
                await connection.QuerySingleOrDefaultAsync(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
            return true;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
            IEnumerable<Comment> comments;
            string sp = "SP_GetCommentsByPostId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                comments = await connection.QueryAsync<Comment>(
                    sp,
                    commandType: CommandType.StoredProcedure
                );
            }

            return comments;
        }

        public async Task<Comment> UpdateComment(Comment comment)
        {
            string sp = "SP_UpdateComment";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CommentId", comment.Id);
                parameters.Add("@Description", comment.Description);
                parameters.Add("@PostId", comment.PostId);
                await connection.QuerySingleOrDefaultAsync<int>(
                    sp,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
            return comment;
        }
    }
}
