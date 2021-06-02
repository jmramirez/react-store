using System;

namespace ReactStore.Domain.Entities
{
    public class ProductFeature
    {
        public Guid ProductId { get; set; }
        public Guid FeatureId { get; set; }
        
        public Product Product { get; set; }
        public Feature Feature { get; set; }
    }
}