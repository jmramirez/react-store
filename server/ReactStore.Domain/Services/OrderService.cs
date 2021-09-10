using System;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;
using System.Linq;
using ReactStore.Domain.Mappers;
using ReactStore.Domain.Repositories;
using ReactStore.Domain.Requests.Order;
using ReactStore.Domain.Responses;
using Stripe;

namespace ReactStore.Domain.Services
{
    public interface IOrderService
    {
        Task<OrderCreatedResponse> AddOrderAsync(CreateOrderRequest request, string username);
    }
    
    
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderMappers _orderMappers;
        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository orderRepository, IOrderMappers orderMappers, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _orderMappers = orderMappers;
            _userRepository = userRepository;
        }

        public async Task<OrderCreatedResponse> AddOrderAsync(CreateOrderRequest request, string username)
        {
            try
            {
                var order = _orderMappers.Map(request);
                var user = await _userRepository.GetByEmailAsync(username);
                user.Orders.Add(order);
                await _orderRepository.UnitOfWork.SaveChangesAsync();

                var orderItems = await _orderRepository.GetTotal(order.Id);
            
                
            
                var charges = new ChargeService();
                var charge = await charges.CreateAsync(new ChargeCreateOptions
                {
                    Amount = 123,
                    Description = $"Order {order.Id} payment",
                    Currency = "CAD",
                    Source = request.StripeToken
                });
            
                if (string.IsNullOrEmpty(charge.FailureCode))
                {
                    order.PaymentStatus = PaymentStatus.Paid;
                }
                else
                {
                    order.PaymentStatus = PaymentStatus.Declined;
                }

                _orderRepository.Update(order);
                await _orderRepository.UnitOfWork.SaveChangesAsync();
            
                return _orderMappers.Map(order, order.PaymentStatus.ToString());
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}