using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;
using System.Linq;

namespace FA.JustBlog.Core.Repositoties
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        private readonly JustBlogContext _context;

        public TagRepository(JustBlogContext context) : base(context)
        {
            _context = context;
        }

        public void DeleteTag(string tagId)
        {
            if (tagId != null)
            {
                var tag = _dbSet.FirstOrDefault(item => item.TagId == tagId);
                if (tag != null)
                {
                    _dbSet.Remove(tag);
                    _context.SaveChanges();
                }
            }
        }

        public Tag GetTagByUrl(string urlSlug)
        {
            return _dbSet.FirstOrDefault(item => item.UrlSlug == urlSlug);
        }
    }
}
