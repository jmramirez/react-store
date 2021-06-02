using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure
{
    public class ReactStoreContext : IdentityDbContext<AppUser, AppRole, int>, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "reactstore";
        
        public ReactStoreContext(DbContextOptions<ReactStoreContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(builder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}