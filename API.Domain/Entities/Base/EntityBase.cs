using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата и время создания сущности
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата и время обновления сущности
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
