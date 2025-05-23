﻿using DonantsApp.Models;

namespace DonantsApp.Services.Models.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetPostsAsync(int? accountId = null);
        Task<Post> GetPostByIdAsync(int postId);
        Task<Post> CreatePostAsync(Post post);
        Task<bool> UpdatePostAsync(Post post);
        Task<bool> DeletePostAsync(int postId);
    }
}
