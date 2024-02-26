using WMS.Core.Ports.Driven;
using WMS.Core.Ports.Driving;

namespace WMS.Core.Application
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderReader orderReader;

        public OrderService(IOrderReader orderReader)
        {
            this.orderReader = orderReader;
        }

        public IEnumerable<string> GetOrders()
        {
            return orderReader.GetOrders();
        }
    }
}
