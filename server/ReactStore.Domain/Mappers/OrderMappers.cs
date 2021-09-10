using System.Linq;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Requests.Order;
using ReactStore.Domain.Responses;

namespace ReactStore.Domain.Mappers
{
    public interface IOrderMappers
    {
        Order Map(CreateOrderRequest request);
        OrderItem Map(OrderItemRequest request);
        OrderCreatedResponse Map(Order order, string paymentStatus);
    }
    
    public class OrderMappers : IOrderMappers
    {
        public Order Map(CreateOrderRequest request)
        {
            if (request == null) return null;

            var order = new Order
            {
                DeliveryAddress = new Address
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Address1 = request.Address1,
                    Address2 = request.Address2,
                    TownCity = request.TownCity,
                    Country = request.Country,
                    Postcode = request.Postcode
                },
                Items = request.Items.Select(x => Map(x)).ToList()
            };

            return order;
        }

        public OrderItem Map(OrderItemRequest request)
        {
            if (request == null) return null;

            var orderItem = new OrderItem
            {
                ProductId = request.ProductId,
                ColorId = request.ColorId,
                StorageId = request.StorageId,
                Quantity = request.Quantity
            };

            return orderItem;
        }

        public OrderCreatedResponse Map(Order order, string paymentStatus)
        {
            if (order == null) return null;

            var response = new OrderCreatedResponse
            {
                OrderId = order.Id,
                PaymentStatus = paymentStatus
            };

            return response;
        }
    }
}