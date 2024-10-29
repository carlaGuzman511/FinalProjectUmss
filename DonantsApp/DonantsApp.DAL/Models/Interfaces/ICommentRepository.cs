using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetCommentsAsync(int postId);

        Task<Comment> GetCommentByIdAsync(int commentId);

        Task<Comment> CreateComment(Comment comment);

        Task<Comment> UpdateComment(Comment comment);

        Task <bool> DeleteComment(int commentId);
    }
}
