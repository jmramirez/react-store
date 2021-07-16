using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;

namespace ReactStore.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<bool> AuthenticateAsync(string email, string password, CancellationToken cancellationToken = default);
        Task<bool> SignUpAsync(AppUser user, string password, CancellationToken cancellationToken = default);
        Task<AppUser> GetByEmailAsync(string requestEmail, CancellationToken cancellationToken = default);
        Task<IEnumerable<string>> GetUserRoles(string requestEmail, CancellationToken cancellationToken = default);
    }
}