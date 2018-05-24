using System;
using System.Collections.Generic;
using System.Text;

namespace Empeek.Api.Contracts.Entities
{
    public abstract class BaseEntity<TKey> where TKey : IComparable
    {
        public TKey Id { get; set; }
    }
}
