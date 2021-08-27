using System;
using System.Collections.Generic;

namespace ReactStore.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Placed { get; set; } = DateTime.UtcNow;
        
        public List<OrderItem> Items { get; set; }
        public Address DeliveryAddress { get; set; }
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
        public AppUser User { get; set; }
    }
}