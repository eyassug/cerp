using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Common.Data
{
    /// <summary>
    /// Base class for all Repositories. DbContext must inherit IUnitOfWork
    /// </summary>
    /// <typeparam name="TContext">Entity Framework data context type (class) (eg. MusicStoreEntities)</typeparam>
    /// <typeparam name="TEntity">Entity type (class) (eg. Artist, Genre)</typeparam>
    public abstract class EntityFrameworkRepository<TContext,TEntity> : IRepository<TEntity> where TContext: DbContext, IUnitOfWork, new() where TEntity : class
    {
        protected TContext Context;

        #region Constructors
        protected EntityFrameworkRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            Context = unitOfWork as TContext;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Used to add an entity to the Context's db set
        /// </summary>
        /// <param name="entity">Entity to be added</param>
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Used to get an IQueryable collection of all objects in the db set
        /// </summary>
        /// <returns>A collection of all objects in the db set</returns>
        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            return query;
        }
        
        /// <summary>
        /// Accepts a filter to query a db set
        /// </summary>
        /// <param name="filter">Lambda expression (TEntity => TEntity.[Property] == value)</param>
        /// <returns>IQueryable collection of entities in a db set that match the supplied filter</returns>
        public IQueryable<TEntity> FindBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().Where(filter);
            return query;
        }

        /// <summary>
        /// Accepts a filter to query a db set
        /// </summary>
        /// <param name="filter">Lambda expression (TEntity => TEntity.[Property] == value)</param>
        /// <returns>A single instance of the entity that matches the supplied filter (if found), null if not. Throws exception if more than one entities match the supplied filter.</returns>
        public TEntity FindSingle(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return FindBy(filter).SingleOrDefault();
        }

        /// <summary>
        /// Used to get the first occurence of an entity with supplied filter and ordering
        /// </summary>
        /// <param name="filter">Lambda expression (TEntity => TEntity.[Property] == value)</param>
        /// <param name="orderBy">(Optional) Lambda expression (TEntity => TEntity.[Property])</param>
        /// <returns>The first entity in the db set ordered by the supplied ordering and matches the supplied filter</returns>
        public TEntity FindFirst(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter, params System.Linq.Expressions.Expression<Func<TEntity, object>>[] orderBy)
        {
            TEntity entity;
            var entities = FindBy(filter).OrderBy(orderBy.First());
            if(orderBy != null && orderBy.Length > 0)
            {
                if(orderBy.Length > 1)
                {
                    entities = orderBy.Aggregate(entities, (current, expression) => current.OrderBy(expression));
                }
            }
            return entities.FirstOrDefault();
        }

        public IQueryable<TEntity> Top<TKey>(int count, Expression<Func<TEntity, TKey>> orderBy)
        {
            return Context.Set<TEntity>().OrderBy(orderBy).Take(count);
        }

        #endregion



    }
}
