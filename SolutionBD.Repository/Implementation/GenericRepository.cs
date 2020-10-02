using Microsoft.EntityFrameworkCore;
using SolutionBD.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Repository.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal SqlServerDBContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(SqlServerDBContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }



        public async Task<int> CountAll()
        {
            return await dbSet.CountAsync();
        }

        public async Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(predicate).CountAsync();
        }

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }




        public async Task<int> SaveChanges()
        {
            var responseResult = await context.SaveChangesAsync();
            return responseResult;
        }






        public async Task AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);

        }

        public async Task AddAllAsync(List<TEntity> entity)
        {
            await dbSet.AddRangeAsync(entity);

        }
        //
        public TEntity Remove(TEntity entity)
        {
            context.Remove(entity);
            return entity;
        }
        public List<TEntity> RemoveAll(List<TEntity> entity)
        {
            context.RemoveRange(entity);
            return entity;
        }
        // 
        public TEntity Update(TEntity entity)
        {
            context.Update(entity);
            return entity;
        }
        public List<TEntity> UpdateAll(List<TEntity> entity)
        {
            context.UpdateRange(entity);
            return entity;
        }


        public virtual IEnumerable<TEntity> GetWithRawSql(string query,
            params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters).ToList();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

      
    }

}
