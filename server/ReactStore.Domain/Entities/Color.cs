using System;
using System.Collections.Generic;

namespace ReactStore.Domain.Entities
{
    public class Color
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductVariant> ProductVariants { get; set; }
    }
}