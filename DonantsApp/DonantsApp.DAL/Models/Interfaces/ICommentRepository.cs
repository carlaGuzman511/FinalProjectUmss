using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);

        Task<Comment> GetCommentByIdAsync(int commentId);

        Task<Comment> CreateCommentAsync (Comment comment);

        Task UpdateCommentAsync (Comment comment);

        Task DeleteCommentAsync (int commentId);
    }
}
