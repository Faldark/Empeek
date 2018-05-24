using System;
using System.Collections.Generic;
using System.Text;

namespace Empeek.Api.Contracts.Entities
{
    public class ItemName : BaseEntity<long>
    {
        public ItemName() {
            this.ItemType = new ItemType();
        }
        public string Name { get; set; }
        public ItemType ItemType { get; set; }
        public long ItemTypeId { get; set; }
    }
}
