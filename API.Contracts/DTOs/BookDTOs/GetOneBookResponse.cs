using API.Contracts.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Contracts.DTOs.BookDTOs
{
    public class GetOneBookResponse : DTOBase
    {
        /// <summary>
        /// Заголовок книги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание книги
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }
    }
}
