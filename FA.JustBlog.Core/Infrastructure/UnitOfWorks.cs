using FA.JustBlog.Core.Repositoties;

namespace FA.JustBlog.Core.Infrastructure
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly JustBlogContext _context;

        private ICategoryRepository _categoryRepository;

        private ITagRepository _tagRepository;

        private IPostRepository _postRepository;

        public UnitOfWorks(JustBlogContext context)
        {
            _context = context;
        }

        public JustBlogContext JustBlogContext => _context;

        public ICategoryRepository CategoryRepository => _categoryRepository ?? (_categoryRepository = new CategoryRepository(_context));

        public IPostRepository PostRepository => _postRepository ?? (_postRepository = new PostRepository(_context));

        public ITagRepository TagRepository => _tagRepository ?? (_tagRepository = new TagRepository(_context));

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
