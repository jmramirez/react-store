using System;

namespace ReactStore.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public Guid StorageId { get; set; }
        public int Quantity { get; set; }
        
        public ProductVariant ProductVariant { get; set; }
    }
}