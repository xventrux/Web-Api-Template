using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Contracts.DTOs.BookDTOs
{
    /// <summary>
    /// Форма создания новой книги
    /// </summary>
    public class CreateBookRequest
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
