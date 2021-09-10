using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;

namespace ReactStore.Domain.Repositories
{
    public interface IOrderRepository : IRepository
    {
        Task<IEnumerable<Order>> GetAsync();
        Task<int> GetTotal(int id);
        Order Update(Order order);
    }
}