using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReactStore.Domain.Requests.Order;
using ReactStore.Domain.Requests.User;
using ReactStore.Domain.Services;

namespace ReactStore.API.Controllers
{
    [Authorize]
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        [HttpPost, Authorize(Roles = "Customer")]
        public async Task<IActionResult> Post(CreateOrderRequest request)
        {
            var username = HttpContext.User.Identity.Name;
            var result = await _orderService.AddOrderAsync(request,username);

            if (result == null) return BadRequest(new {message = "There was a problem with payment"});
            return Ok(result);
        }
    }
}