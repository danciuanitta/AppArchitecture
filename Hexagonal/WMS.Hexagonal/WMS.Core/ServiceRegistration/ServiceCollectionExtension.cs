using Microsoft.Extensions.DependencyInjection;
using WMS.Core.Application;
using WMS.Core.Ports.Driving;

namespace WMS.Core.ServiceRegistration
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterCore(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IOrderService, OrderService>();
        }
    }
}
