using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReactStore.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SavEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}