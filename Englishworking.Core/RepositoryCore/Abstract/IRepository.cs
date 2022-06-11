using Englishworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Englishworking.Core.RepositoryCore.Abstract
{
    public interface IRepository<TEntity> where TEntity:class, IEntity, new()
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll(params string[] includeList);
        IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity,bool>> filter, params string[] includeList);
    }
}
