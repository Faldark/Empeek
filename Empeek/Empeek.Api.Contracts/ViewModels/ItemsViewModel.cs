using Empeek.Api.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empeek.Api.Contracts.ViewModels
{
    public class ItemsViewModel
    {
        public IEnumerable<ItemDTO> Items { get; set; }
    }
}
