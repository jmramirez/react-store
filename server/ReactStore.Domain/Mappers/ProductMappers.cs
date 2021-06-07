using System.Linq;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Responses;

namespace ReactStore.Domain.Mappers
{
    public interface IProductMappers
    {
        ProductForListResponse Map(Product request);
    }
    
    public class ProductMappers : IProductMappers
    {
        public ProductForListResponse Map(Product request)
        {
            if (request == null) return null;

            var response = new ProductForListResponse
            {
                Id = request.Id,
                Slug = request.Slug,
                Name = request.Name,
                ShortDescription = request.ShortDescription,
                Thumbnail = request.Thumbnail,
                Price = request.ProductVariants.OrderBy(v => v.Price).First().Price
            };

            return response;
        }
    }
}