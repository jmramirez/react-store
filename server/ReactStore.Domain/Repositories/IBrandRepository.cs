using System.Collections.Generic;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;

namespace ReactStore.Domain.Repositories
{
    public interface IBrandRepository : IRepository
    {
        Task<IEnumerable<Brand>> GetAsync();
    }
}