using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Tiendeo.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository()
        {
        }

        public virtual IEnumerable<TEntity> Get(
            Context context,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = context.Set<TEntity>();

            if (filter != null)
                query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(includeProperty);

            if (orderBy != null)
                return orderBy(query).ToList();
            else
                return query.ToList();

        }

        public virtual TEntity GetByID(Context context, object id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual TEntity Insert(Context context, TEntity entity)
        {
            return context.Set<TEntity>().Add(entity).Entity;
        }

        public virtual void Delete(Context context, object id)
        {
            TEntity entityToDelete = context.Set<TEntity>().Find(id);
            Delete(context, entityToDelete);
        }

        public virtual void Delete(Context context, TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
                context.Set<TEntity>().Attach(entityToDelete);

            context.Set<TEntity>().Remove(entityToDelete);
        }

        public virtual TEntity Update(Context context, TEntity entityToUpdate)
        {
            EntityEntry<TEntity> a = context.Set<TEntity>().Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            return a.Entity;
        }
    }
}
