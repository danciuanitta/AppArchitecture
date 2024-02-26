using Microsoft.AspNetCore.Mvc;
using WMS.Core.Ports.Driving;

namespace WMS.Adapter.Api.Controllers
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
        public IEnumerable<string> Get()
        {
            return orderService.GetOrders();
        }
    }
}