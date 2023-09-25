using API.Contracts.DTOs.BookDTOs;
using API.Domain.Entities;
using API.Infrastructure.Repository;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public BookService(IRepository<Book> bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task CreateAsync(CreateBookRequest request)
        {
            Book book = _mapper.Map<Book>(request);
            book.CreationDate = DateTime.Now;
            book.UpdateDate = DateTime.Now;
            
            await _bookRepository.AddAsync(book);
        }

        /// <inheritdoc/>
        public async Task DeleteAsync(Guid id)
        {
            Book book = await _bookRepository.GetByIdAsync(id);

            await _bookRepository.DeleteAsync(book);
        }

        /// <inheritdoc/>
        public async Task EditAsync(EditBookRequest request)
        {
            Book book = _mapper.Map<Book>(request);

            await _bookRepository.UpdateAsync(book);
        }

        /// <inheritdoc/>
        public List<GetManyBooksResponse> GetAll()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            return _mapper.Map<List<GetManyBooksResponse>>(books);
        }

        /// <inheritdoc/>
        public async Task<GetOneBookResponse> GetByIdAsync(Guid id)
        {
            Book book = await _bookRepository.GetByIdAsync(id);

            return _mapper.Map<GetOneBookResponse>(book);
        }
    }
}
