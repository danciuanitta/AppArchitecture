
namespace WMS.Core.Ports.Driving
{
    public interface IOrderService
    {
        IEnumerable<GetOrderResponse> GetOrders();
    }
}
