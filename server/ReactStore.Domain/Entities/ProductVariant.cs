using System;

namespace ReactStore.Domain.Entities
{
    public class ProductVariant
    {
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public Guid StorageId { get; set; }
        public decimal Price { get; set; }
        
        public Product Product { get; set; }
        public Color Color { get; set; }
        public Storage Storage { get; set; }
    }
}