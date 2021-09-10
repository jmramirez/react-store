using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ReactStoreContext _context;

        public OrderRepository(ReactStoreContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Order>> GetAsync()
        {
            return await _context.Orders
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> GetTotal(int id)
        {
            var order = await _context.Orders
                .Where(x => x.Id == id)
                .Include(x => x.Items)
                .ThenInclude(p => p.ProductVariant)
                .Select(x => Convert.ToInt32(x.Items.Sum(i => i.ProductVariant.Price * i.Quantity))).FirstAsync();

            return order;

        }
        
        public Order Update(Order item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return item;
        } 

    }
}