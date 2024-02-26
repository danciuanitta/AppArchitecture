using WMS.Core.Ports.Driven;
using WMS.Core.Ports.Driving;
using System.Linq;

namespace WMS.Core.Application
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderReader orderReader;

        public OrderService(IOrderReader orderReader)
        {
            this.orderReader = orderReader;
        }

        public IEnumerable<GetOrderResponse> GetOrders()
        {
            var orderEntities = orderReader.GetOrders();
            return (orderEntities.Select(orderEntity => new GetOrderResponse() { Id = orderEntity.Id })).ToList();
        }
    }
}
