using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;

namespace DonantsApp.Services.Comments
{
    public class CommentService : ICommentService
    {
        internal readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            this._commentRepository = commentRepository;
        }
        public Task<Comment> CreateCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCommentAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetCommentByIdAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetCommentsAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
