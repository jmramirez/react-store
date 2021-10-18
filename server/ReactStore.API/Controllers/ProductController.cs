using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactStore.Domain.Services;

namespace ReactStore.API.Controllers
{
    [Route("api/products")]
    [ApiController]   
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string q, string brands, int? minPrice, int? maxPrice, int? minScreen,
            int? maxScreen, string storage, string colors, string os, string features)
        {
            var result = await _productServices.GetProductsAsync( q, brands, minPrice, maxPrice, minScreen, maxScreen, storage, colors, os, features);
            return Ok(result);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            var product = await _productServices.GetProductBySlug(slug);
            return Ok(product);
        }
        
    }
}