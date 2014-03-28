using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Common.Data
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void Add(TEntity entity);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> FindBy(Expression<Func<TEntity,bool>> filter);
        TEntity FindSingle(Expression<Func<TEntity, bool>> filter);
        TEntity FindFirst(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] orderBy);
    }
}
