using System;
using System.Collections.Generic;
using System.Text;

namespace Empeek.Api.Contracts.Entities
{
    public class ItemType: BaseEntity<long>
    {
        public ItemType() {
            this.ItemNames = new List<ItemName>();
        }
        public string Type { get; set; }
        public ICollection<ItemName> ItemNames { get; set; }
    }
}
