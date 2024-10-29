using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;

namespace DonantsApp.DAL
{
    public class CommentRepository : ICommentRepository
    {
        public Task<Comment> CreateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentByIdAsync(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetCommentsAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
