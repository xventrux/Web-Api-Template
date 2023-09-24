using API.Contracts.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Contracts.DTOs.BookDTOs
{
    public class GetManyBooksResponse : DTOBase
    {
        /// <summary>
        /// Заголовок книги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }
    }
}
