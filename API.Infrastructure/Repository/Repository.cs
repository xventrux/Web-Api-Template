using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Repository
{
    /// <inheritdoc/>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext DbContext { get; }
        protected DbSet<TEntity> DbSet { get; }

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }

        /// <inheritdoc/>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
        /// <inheritdoc/>
        public IQueryable<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicat)
        {
            if (predicat == null) throw new ArgumentNullException(nameof(predicat));
            return DbSet.Where(predicat);
        }
        /// <inheritdoc/>
        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await DbSet.FindAsync(id);
        }

        /// <inheritdoc/>
        public Task AddAsync(TEntity model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            DbSet.Add(model);
            return SaveChangesAsync();
        }
        /// <inheritdoc/>
        public Task UpdateAsync(TEntity model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            DbSet.Update(model);
            return SaveChangesAsync();
        }
        /// <inheritdoc/>
        public Task DeleteAsync(TEntity model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            DbSet.Remove(model);
            return SaveChangesAsync();
        }
        /// <inheritdoc/>
        public Task SaveChangesAsync()
        {
            return DbContext.SaveChangesAsync();
        }
    }
}
