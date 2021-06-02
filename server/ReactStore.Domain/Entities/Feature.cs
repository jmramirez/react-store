using System;
using System.Collections.Generic;

namespace ReactStore.Domain.Entities
{
    public class Feature
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductFeature> ProductFeatures { get; set; }
    }
}