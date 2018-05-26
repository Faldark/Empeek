using Empeek.Api.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empeek.Api.Contracts.DTO
{
    public class ItemDTO : BaseEntity<long>
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
