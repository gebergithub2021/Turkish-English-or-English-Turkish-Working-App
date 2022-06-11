using Englishworking.Core.RepositoryCore.Abstract;
using Englishworking.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Core.RepositoryCore.Concrete
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
                                                       where TEntity : class, IEntity, new()
                                                        where TContext : DbContext, new()
    {
        public void Delete(int id)
        {
            using (TContext context = new TContext())
            {
                context.Entry(id).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<TEntity> GetAll(params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> _dbSet= context.Set<TEntity>().AsQueryable();
                if (includeList.Length>0)
                {
                    foreach (var item in includeList)
                    {
                        _dbSet = _dbSet.Include(item);
                    }
                }
                return _dbSet.ToList();
            }
        }

        public IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> _dbSet = context.Set<TEntity>().AsQueryable();
                if (includeList.Length > 0)
                {
                    foreach (var item in includeList)
                    {
                        _dbSet = _dbSet.Include(item);
                    }
                }
                return _dbSet.Where(filter).ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
