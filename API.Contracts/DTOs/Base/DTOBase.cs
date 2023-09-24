using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Contracts.DTOs.Base
{
    /// <summary>
    /// Data Transfer Object
    /// </summary>
    public class DTOBase
    {
        /// <summary>
        /// Идентификтор объекта
        /// </summary>
        public Guid Id { get; set; }
    }
}
