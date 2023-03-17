using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace EntityFramework
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IAggregateRoot
    {
        protected readonly DbContext Context;

        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            Context = context;

            if (context != null)
            {
                _dbSet = context.Set<TEntity>();
            }
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync().ConfigureAwait(false);
        }
    }
}
