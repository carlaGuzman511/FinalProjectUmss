using DonantsApp.Models;

namespace DonantsApp.DAL.Models.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPostsAsync(int? accountId = null);

        Task<Post> GetPostByIdAsync(int postId);

        Task<Post> CreatePost(Post post);

        Task<Post> UpdatePostAsync(Post post);

        Task DeletePostAsync(int postId);
    }
}
