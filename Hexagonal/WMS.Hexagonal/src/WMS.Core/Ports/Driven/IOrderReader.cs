
namespace WMS.Core.Ports.Driven
{
    public interface IOrderReader
    {
        IEnumerable<OrderEntity> GetOrders();
    }
}
