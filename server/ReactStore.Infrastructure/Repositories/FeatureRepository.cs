using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly ReactStoreContext _context;

        public FeatureRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Feature>> GetAsync()
        {
            return await _context.Features
                .AsNoTracking()
                .ToListAsync();
        }
    }
}