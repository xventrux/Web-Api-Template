using API.Contracts.DTOs.BookDTOs;
using API.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Mapper.Mapping
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            configureBookModels();
        }

        private void configureBookModels()
        {
            CreateMap<CreateBookRequest, Book>();
            CreateMap<EditBookRequest, Book>();
            CreateMap<Book, GetManyBooksResponse>();
            CreateMap<Book, GetOneBookResponse>();
        }
    }
}
