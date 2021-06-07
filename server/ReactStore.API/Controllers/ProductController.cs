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
            int? maxScreen, string capacity, string colors, string os, string features)
        {
            var result = await _productServices.GetProductsAsync( q, brands, minPrice, maxPrice, minScreen, maxScreen, capacity, colors, os, features);
            return Ok(result);
        }
    }
}