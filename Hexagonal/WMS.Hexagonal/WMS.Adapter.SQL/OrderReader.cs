using WMS.Core.Ports.Driven;

namespace WMS.Adapter.SQL
{
    internal class OrderReader : IOrderReader
    {
        public IEnumerable<string> GetOrders()
        {
            return new List<string>() { "order1", "order2"};
        }
    }
}