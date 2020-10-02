using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        IEnumerable<TEntity> GetWithRawSql(string query,
            params object[] parameters);
        Task<TEntity> GetById(int id);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        //
        Task AddAsync(TEntity entity);
        Task AddAllAsync(List<TEntity> entity);

        TEntity Update(TEntity entity);
        TEntity Remove(TEntity entity);
        //
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}
