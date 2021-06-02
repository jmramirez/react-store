using System;
using System.Collections.Generic;

namespace ReactStore.Domain.Entities
{
    public class Storage
    {
        public Guid Id { get; set; }
        public string Capacity { get; set; }
        public IEnumerable<ProductVariant> ProductVariants { get; set; }
    }
}