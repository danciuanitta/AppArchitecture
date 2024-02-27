using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using WMS.Core.Ports.Driving;

namespace WMS.Adapter.Driving
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            this.orderService = orderService;
        }

        [HttpGet(Name = "GetOrders")]
        public IActionResult Get()
        {
            return Ok(orderService.GetOrders());
        }
    }
}