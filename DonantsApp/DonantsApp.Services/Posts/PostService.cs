using DonantsApp.DAL.Models.Interfaces;
using DonantsApp.Models;
using DonantsApp.Services.Models.Interfaces;
using DonantsApp.Services.Validators;
using FluentValidation;

namespace DonantsApp.Services.Posts
{
    public class PostService : IPostService
    {
        internal readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository) 
        { 
            this._postRepository = postRepository;
        }
        public Task<Post> CreatePostAsync(Post post)
        {
            PostValidator postValidator = new PostValidator();
            var result = postValidator.Validate(post, options => options.IncludeRuleSets("Create"));
            return this._postRepository.CreatePost(post);
        }

        public async Task DeletePostAsync(int postId)
        {
            await this._postRepository.DeletePostAsync(postId);
        }

        public Task<Post> GetPostByIdAsync(int postId)
        {
            return this._postRepository.GetPostByIdAsync(postId);   
        }

        public Task<IEnumerable<Post>> GetPostsAsync(int? accountId = null)
        {
            if (accountId != null)
            {
                return this._postRepository.GetPostsAsync(accountId);
            }
            else
            {
                return this._postRepository.GetPostsAsync();
            }
        }

        public Task<Post> UpdatePostAsync(Post post)
        {
            return this._postRepository.UpdatePostAsync(post);
        }
    }
}
