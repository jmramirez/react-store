using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactStore.Domain.Mappers;
using ReactStore.Domain.Repositories;
using ReactStore.Domain.Responses;

namespace ReactStore.Domain.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductForListResponse>> GetProductsAsync(string q, string brands, int? minPrice,
            int? maxPrice, int? minScreen, int? maxScreen, string capacity, string colors, string os, string features);
    }
    
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRespository;
        private readonly IProductMappers _productMapper;

        public ProductServices(IProductRepository productRepository, IProductMappers productMapper)
        {
            _productRespository = productRepository;
            _productMapper = productMapper;
        }

        public async Task<IEnumerable<ProductForListResponse>> GetProductsAsync(string q, string brands, int? minPrice,
            int? maxPrice, int? minScreen, int? maxScreen, string capacity, string colors, string os, string features)
        {
            var products = await _productRespository.GetAsync(q, brands, minPrice, maxPrice, minScreen, maxScreen, capacity, colors, os, features);
            var Features = string.IsNullOrEmpty(features) ? new List<string>() : features.Split('|').ToList();

            var results = products.Where(x => Features.All(f => x.ProductFeatures.Any(pf => pf.Feature.Name == f)));
            return results.
                Select(p => _productMapper.Map(p));
        }
    }
}