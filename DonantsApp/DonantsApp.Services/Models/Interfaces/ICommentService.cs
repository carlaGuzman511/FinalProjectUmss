using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId);

        Task<Comment> CreateCommentAsync(Comment comment);
        
        Task<bool> UpdateCommentAsync(Comment comment);
        
        Task<bool> DeleteCommentAsync(int commentId);
    }
}
