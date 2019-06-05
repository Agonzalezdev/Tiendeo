using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Tiendeo.DAL.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets an entity
        /// </summary>
        /// <param name="filter">Lambda expression (returing boolean) to filter results. Example: user => user.LastName == "Smith"</param>
        /// <param name="orderBy">Lambda expression to order results. Example: q => q.OrderBy(u => u.LastName)</param>
        /// <param name="includeProperties">Comma-delimited values to be returned in query. Example: Name,LastName,DateOfBirth</param>
        /// <returns>List of entities matching filters provided</returns>
        IEnumerable<TEntity> Get(Context context, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        /// <summary>
        /// Gets an entity by Id
        /// </summary>
        /// <param name="id">Id of entity to recover</param>
        /// <returns>Resulting entity. NULL if it do not exist</returns>
        TEntity GetByID(Context context, object id);

        /// <summary>
        /// Creates a new entity
        /// </summary>
        /// <param name="entity">Entity to be inserted</param>
        TEntity Insert(Context context, TEntity entity);

        /// <summary>
        /// Deletes entity by id
        /// </summary>
        /// <param name="id">Id of entity to delete</param>
        void Delete(Context context, object id);

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="entityToDelete">Entity to delete</param>
        void Delete(Context context, TEntity entityToDelete);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entityToUpdate">Entity to update</param>
        TEntity Update(Context context, TEntity entityToUpdate);
    }
}
