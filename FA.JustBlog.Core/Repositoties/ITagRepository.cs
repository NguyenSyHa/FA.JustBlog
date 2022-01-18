using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositoties
{
    public interface ITagRepository : IBaseRepository<Tag>
    {
        void DeleteTag(string tagId);

        Tag GetTagByUrl(string urlSlug);
    }
}
