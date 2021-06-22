using System.Linq;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Responses;

namespace ReactStore.Domain.Mappers
{
    public interface IProductMappers
    {
        ProductForListResponse Map(Product request);
        ProductItemResponse MapProduct(Product request);
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

        public ProductItemResponse MapProduct(Product request)
        {
            if (request == null) return null;

            var response = new ProductItemResponse
            {
                Id = request.Id,
                Slug = request.Slug,
                Name = request.Name,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
                Thumbnail = request.Thumbnail,
                Price = request.ProductVariants.OrderBy(v => v.Price).First().Price,
                Images = request.Images.Select(i => new ImageResponse{ Id = i.Id, Url = i.Url }),
                Features = request.ProductFeatures.Select(pf => new FeatureResponse{ Id = pf.FeatureId, Name = pf.Feature.Name}),
                ProductVariants = request.ProductVariants.Select(pv => new VariantsResponse
                {
                    ProductId = request.Id,
                    Name = request.Name,
                    Thumbnail = request.Thumbnail,
                    ColorId = pv.ColorId,
                    Color = pv.Color.Name,
                    StorageId = pv.StorageId,
                    Capacity = pv.Storage.Capacity,
                    Price = pv.Price
                })
            };
            
            return response;
        }
    }
}