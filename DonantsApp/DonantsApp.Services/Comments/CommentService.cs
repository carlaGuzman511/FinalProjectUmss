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
        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            //todo add commentvalidators, review post validators
            return await _commentRepository.CreateComment(comment);
        }

        public async Task<bool> DeleteCommentAsync(int commentId)
        {
            return await _commentRepository.DeleteComment(commentId);
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
           return await _commentRepository.GetCommentsByPostIdAsync(postId);
        }

        public Task<Comment> UpdateCommentAsync(Comment comment)
        {
            return _commentRepository.UpdateComment(comment);
        }
    }
}
