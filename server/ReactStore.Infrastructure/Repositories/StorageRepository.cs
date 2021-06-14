using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class StorageRepository : IStorageRepository
    {
        private readonly ReactStoreContext _context;

        public StorageRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Storage>> GetAsync()
        {
            return await _context.Storage
                .AsNoTracking()
                .ToListAsync();
        }
    }
}