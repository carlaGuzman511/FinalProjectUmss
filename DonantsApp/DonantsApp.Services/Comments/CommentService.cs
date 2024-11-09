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
            return await _commentRepository.CreateCommentAsync(comment);
        }

        public async Task<bool> DeleteCommentAsync(int commentId)
        {
            Comment oldComment = await _commentRepository.GetCommentByIdAsync(commentId);
            if (oldComment != null)
            {
                await _commentRepository.DeleteCommentAsync(commentId);
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(int postId)
        {
           return await _commentRepository.GetCommentsByPostIdAsync(postId);
        }

        public async Task<bool> UpdateCommentAsync(Comment comment)
        {
            Comment oldComment = await _commentRepository.GetCommentByIdAsync(comment.Id);
            if (oldComment != null)
            {
                oldComment.Description = comment.Description; 
                await _commentRepository.UpdateCommentAsync(comment);
                return true;
            }

            return false;
        }
    }
}
