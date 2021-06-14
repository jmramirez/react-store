using System.Collections.Generic;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;

namespace ReactStore.Domain.Repositories
{
    public interface IOSRepository : IRepository
    {
        Task<IEnumerable<OS>> GetAsync();
    }
}