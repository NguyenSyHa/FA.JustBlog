using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;
using System.Linq;

namespace FA.JustBlog.Core.Repositoties
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly JustBlogContext _context;

        public CategoryRepository(JustBlogContext context) : base(context)
        {
            _context = context;
        }

        public void DeleteCategory(int categoryId)
        {
            if (categoryId > 0)
            {
                var category = _dbSet.FirstOrDefault(item => item.CategoryId == categoryId);
                if (category != null)
                {
                    _dbSet.Remove(category);
                }
            }
        }
    }
}
