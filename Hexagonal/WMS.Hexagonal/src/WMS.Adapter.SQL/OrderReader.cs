using WMS.Core.Ports.Driven;

namespace WMS.Adapter.SQL
{
    internal class OrderReader : IOrderReader
    {
        public IEnumerable<OrderEntity> GetOrders()
        {
            return new List<OrderEntity>() { new OrderEntity() { Id = 1 } };
        }
    }
}