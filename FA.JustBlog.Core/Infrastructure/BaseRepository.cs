using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FA.JustBlog.Core.Infrastructure
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly JustBlogContext _context;
        public DbSet<TEntity> _dbSet { get; set; }

        public BaseRepository(JustBlogContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Add(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> condition)
        {
            return _dbSet.FirstOrDefault(condition);
        }

        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Update(entity);
            }
        }
    }
}
