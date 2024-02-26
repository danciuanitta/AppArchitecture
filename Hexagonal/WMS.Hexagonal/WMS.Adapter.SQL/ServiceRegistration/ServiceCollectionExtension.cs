using Microsoft.Extensions.DependencyInjection;
using WMS.Core.Ports.Driven;

namespace WMS.Adapter.SQL.ServiceRegistration
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterAdapterSql(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IOrderReader, OrderReader>();
        }
    }
}
