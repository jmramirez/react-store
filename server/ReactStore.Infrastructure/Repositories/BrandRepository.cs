using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ReactStoreContext _context;

        public BrandRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Brand>> GetAsync()
        {
            return await _context.Brands
                .AsNoTracking()
                .ToListAsync();
        }
    }
}