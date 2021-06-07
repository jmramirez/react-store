using System.Collections.Generic;
using System.Threading.Tasks;
using ReactStore.Domain.Entities;

namespace ReactStore.Domain.Repositories
{
    public interface IProductRepository : IRepository
    {
        Task<IEnumerable<Product>> GetAsync(string q, string brands, int? minPrice, int? maxPrice, int? minScreen, int? maxScreen, string capacity, string colors, string os, string features);
        Task<Product> GetProductBySlugAsync(string slug);
    }
}