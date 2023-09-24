using API.Contracts.DTOs.BookDTOs;
using API.Domain.Entities;
using API.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.AppServices.Services.BookServices
{
    /// <inheritdoc/>
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        /// <inheritdoc/>
        public Task CreateAsync(CreateBookRequest request)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task EditAsync(EditBookRequest request)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<GetManyBooksResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<GetOneBookResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
