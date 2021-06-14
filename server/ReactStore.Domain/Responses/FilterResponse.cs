using System.Collections.Generic;

namespace ReactStore.Domain.Responses
{
    public class FilterResponse
    {
        public IEnumerable<BrandResponse> Brands { get; set; }
        public IEnumerable<ColorResponse> Colors { get; set; }
        public IEnumerable<StorageResponse> Capacity { get; set; }
        public IEnumerable<OSResponse> OS { get; set; }
        public IEnumerable<FeatureResponse> Features { get; set; }
    }
}