
namespace WMS.Core.Ports.Driven
{
    public interface IOrderReader
    {
        IEnumerable<string> GetOrders();
    }
}
