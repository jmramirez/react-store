using System.Linq;
using System.Threading.Tasks;
using ReactStore.Domain.Repositories;
using ReactStore.Domain.Responses;

namespace ReactStore.Domain.Services
{
    public interface IFilterService
    {
        Task<FilterResponse> GetFiltersList();
    }
    
    public class FilterService : IFilterService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IColorRepository _colorRepository;
        private readonly IOSRepository _osRepository;
        private readonly IStorageRepository _storageRepository;
        private readonly IFeatureRepository _featureRepository;

        public FilterService(IBrandRepository brandRepository, IColorRepository colorRepository,
            IOSRepository osRepository, IStorageRepository storageRepository, IFeatureRepository featureRepository)
        {
            _brandRepository = brandRepository;
            _colorRepository = colorRepository;
            _featureRepository = featureRepository;
            _osRepository = osRepository;
            _storageRepository = storageRepository;
        }

        public async Task<FilterResponse> GetFiltersList()
        {
            var brands = await _brandRepository.GetAsync();
            var colors = await _colorRepository.GetAsync();
            var features = await _featureRepository.GetAsync();
            var os = await _osRepository.GetAsync();
            var storage = await _storageRepository.GetAsync();

            return new FilterResponse
            {
                Brands = brands.Select(x => new BrandResponse {Id = x.Id, Name = x.Name}),
                Colors = colors.Select(x => new ColorResponse {Id = x.Id, Name = x.Name}),
                Features = features.Select(x => new FeatureResponse {Id = x.Id, Name = x.Name}),
                OS = os.Select(x => new OSResponse {Id = x.Id, Name = x.Name}),
                Capacity = storage.Select(x => new StorageResponse {Id = x.Id, Capacity = x.Capacity})
            };
        }
    }
}