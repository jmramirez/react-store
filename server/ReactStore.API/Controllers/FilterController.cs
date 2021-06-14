using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactStore.Domain.Services;

namespace ReactStore.API.Controllers
{
    [Route("api/filters")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IFilterService _filterService;

        public FilterController(IFilterService filterService)
        {
            _filterService = filterService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _filterService.GetFiltersList();
            return Ok(result);
        }
    }
}