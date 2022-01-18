using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FA.JustBlog.Core.Repositoties
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        private readonly JustBlogContext _context;

        public PostRepository(JustBlogContext context) : base(context)
        {
            _context = context;
        }

        public int CountPostsForCategory(string category)
        {
            return _context.Posts.Where(item => item.Category.Name == category).ToList().Count();
        }

        public int CountPostsForTag(string tag)
        {
            var resultPost = (from post in _context.Posts
                              join pm in _context.PostTagMaps on post.PostId equals pm.PostId
                              join tags in _context.Tags on pm.TagId equals tags.TagId
                              select new
                              {
                                  PostName = post.Title,
                                  TagName = tags.Name,
                              }).Where(item => item.TagName == tag).ToList();

            return resultPost.Count();
        }

        public void DeletePost(string postId)
        {
            if (postId != null)
            {
                var post = _dbSet.FirstOrDefault(item => item.PostId == postId);
                if (post != null)
                {
                    _dbSet.Remove(post);
                }
            }
        }

        public IList<Post> GetLatestPost(int size)
        {
            return _context.Posts.Where(item => item.Count == size).ToList();
        }

        public Post GetPostByUrl(int year, int month, string urlSlug)
        {
            return _context.Posts.FirstOrDefault(item => item.UrlSlug == urlSlug);
        }

        public IList<Post> GetPostsByMonth(DateTime monthYear)
        {
            return _context.Posts.Where(item => item.Published == monthYear).ToList();
        }

        public IList<Post> GetPostsForCategory(string category)
        {
            return _context.Posts.Where(item => item.Category.Name == category).ToList();
        }

        public IList<Post> GetPostsForTag(string tag)
        {
            var resultPost = (from post in _context.Posts
                              join pm in _context.PostTagMaps on post.PostId equals pm.PostId
                              join tags in _context.Tags on pm.TagId equals tags.TagId
                              select new
                              {
                                  PostName = post.Title,
                                  TagName = tags.Name,
                              }).Where(item => item.TagName == tag);

            return (IList<Post>)resultPost.ToList();
        }

        public IList<Post> GetPublishedPost()
        {
            return _context.Posts.Where(item => item.Published != null).ToList();
        }

        public IList<Post> GetUnpublishedPosts()
        {
            return _context.Posts.Where(item => item.Published == null).ToList();
        }
    }
}
