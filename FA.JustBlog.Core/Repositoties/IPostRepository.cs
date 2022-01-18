using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;

namespace FA.JustBlog.Core.Repositoties
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        void DeletePost(string postId);

        Post GetPostByUrl(int year, int month, string urlSlug);

        IList<Post> GetPublishedPost();

        IList<Post> GetUnpublishedPosts();

        IList<Post> GetLatestPost(int size);

        IList<Post> GetPostsByMonth(DateTime monthYear);

        IList<Post> GetPostsForCategory(string category);

        IList<Post> GetPostsForTag(string tag);

        int CountPostsForCategory(string category);

        int CountPostsForTag(string tag);
    }
}
