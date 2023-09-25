using API.Contracts.DTOs.BookDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.AppServices.Services.BookServices
{
    /// <summary>
    /// Сервис для работы с книгами
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Создает новую книгу
        /// </summary>
        /// <returns></returns>
        public Task CreateAsync(CreateBookRequest request);

        /// <summary>
        /// Возвращает книгу по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <returns></returns>
        public Task<GetOneBookResponse> GetByIdAsync(Guid id);

        /// <summary>
        /// Возвращает все книги
        /// </summary>
        /// <returns></returns>
        public List<GetManyBooksResponse> GetAll();

        /// <summary>
        /// Редактирует книгу
        /// </summary>
        /// <param name="request">Форма редактирования книги</param>
        /// <returns></returns>
        public Task EditAsync(EditBookRequest request);

        /// <summary>
        /// Удаляет книгу
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <returns></returns>
        public Task DeleteAsync(Guid id);
    }
}
