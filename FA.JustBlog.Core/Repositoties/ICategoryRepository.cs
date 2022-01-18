using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositoties
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        void DeleteCategory(int categoryId);
    }
}
