using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class OSRepository : IOSRepository
    {
        private readonly ReactStoreContext _context;

        public OSRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<OS>> GetAsync()
        {
            return await _context.OS
                .AsNoTracking()
                .ToListAsync();
        }
    }
}