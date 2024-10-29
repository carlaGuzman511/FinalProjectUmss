using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetCommentsAsync(int postId);

        Task<IEnumerable<Comment>> GetCommentByIdAsync(int commentId);

        Task<Comment> CreateCommentAsync(Comment comment);
        
        Task<Comment> UpdateCommentAsync(Comment comment);
        
        Task<bool> DeleteCommentAsync(int commentId);
    }
}
