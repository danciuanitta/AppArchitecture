using Microsoft.Extensions.DependencyInjection;
using WMS.Core.Ports.Driven;

namespace WMS.Adapter.Queue.ServiceRegistration
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterAdapterQueue(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IQueuePublisher, OrderPublisher>();
        }
    }
}
