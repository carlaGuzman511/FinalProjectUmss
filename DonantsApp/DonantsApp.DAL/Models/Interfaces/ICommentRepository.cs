using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);

        Task<Comment> CreateComment(Comment comment);

        Task<Comment> UpdateComment(Comment comment);

        Task <bool> DeleteComment(int commentId);
    }
}
