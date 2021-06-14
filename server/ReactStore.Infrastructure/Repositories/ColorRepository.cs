using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class ColorRepository : IColorRepository
    {
        private readonly ReactStoreContext _context;

        public ColorRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Color>> GetAsync()
        {
            return await _context.Colors
                .AsNoTracking()
                .ToListAsync();
        }
    }
}