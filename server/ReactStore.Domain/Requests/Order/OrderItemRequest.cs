using System;

namespace ReactStore.Domain.Requests.Order
{
    public class OrderItemRequest
    {
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public Guid StorageId { get; set; }
        public int Quantity { get; set; }
    }
}