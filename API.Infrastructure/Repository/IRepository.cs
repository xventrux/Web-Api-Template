using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Repository
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Сущность</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Возвращает все записи
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Возвращает отфильтрованные записи
        /// </summary>
        /// <param name="predicat"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicat);
        /// <summary>
        /// Возвращает запись по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(Guid id);

        /// <summary>
        /// Добавляет запись
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task AddAsync(TEntity model);

        /// <summary>
        /// Обновляет информацию записи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateAsync(TEntity model);

        /// <summary>
        /// Удалаяет запись
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(TEntity model);

        /// <summary>
        /// Сохраняет изменения
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}
