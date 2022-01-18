using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FA.JustBlog.Core.Infrastructure
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Find(Expression<Func<TEntity, bool>> condition);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IList<TEntity> GetAll();
    }
}
