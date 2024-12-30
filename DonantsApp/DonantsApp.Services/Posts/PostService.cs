using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Validators;

namespace DonantsApp.Services.Posts
{
    public class PostService : IPostService
    {
        internal readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository) 
        { 
            this._postRepository = postRepository;
        }
        public async Task<Post> CreatePostAsync(Post post)
        {
            PostValidator postValidator = new PostValidator();
            var erros = await postValidator.ValidateAsync(post);

            if(erros.Errors.Any())
            {
                throw new ValidationException(erros.Errors);
            }

            return await this._postRepository.CreatePost(post);
        }

        public async Task<bool> DeletePostAsync(int postId)
        {
            Post post = await this._postRepository.GetPostByIdAsync(postId);
            if (post != null)
            {
                await this._postRepository.DeletePostAsync(postId);
                return true;
            }

            return false;
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await this._postRepository.GetPostByIdAsync(postId);   
        }

        public async Task<IEnumerable<Post>> GetPostsAsync(int? accountId = null)
        {
            if (accountId != null)
            {
                return await this._postRepository.GetPostsAsync(accountId);
            }
            else
            {
                return await this._postRepository.GetPostsAsync();
            }
        }

        public async Task<bool> UpdatePostAsync(Post post)
        {
            Post oldPost = await this._postRepository.GetPostByIdAsync(post.Id);
            if (oldPost != null)
            {
                PostValidator postValidator = new PostValidator();
                var erros = await postValidator.ValidateAsync(post);
                if (erros.Errors.Any())
                {
                    throw new ValidationException(erros.Errors);
                }
                await this._postRepository.UpdatePostAsync(post);
                return true;
            }

            return false;
        }
    }
}
