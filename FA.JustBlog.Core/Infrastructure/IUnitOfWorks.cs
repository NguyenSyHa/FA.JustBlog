using FA.JustBlog.Core.Repositoties;
using System;

namespace FA.JustBlog.Core.Infrastructure
{
    public interface IUnitOfWorks : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }
        JustBlogContext JustBlogContext { get; }

        int SaveChanges();
    }
}
