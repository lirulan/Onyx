using Microsoft.AspNetCore.Mvc;
using Onyx.DTO;
using Onyx.Services.Implementations;

namespace Onyx.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto orderDto)
        {
            if (orderDto == null)
            {
                return BadRequest("不可为空");
            }

            await _orderService.CreateOrderAsync(orderDto);
            return Ok("成功");
        }
    }
}
