using Microsoft.Extensions.DependencyInjection;
using WMS.Adapter.Queue.ServiceRegistration;
using WMS.Adapter.SQL.ServiceRegistration;
using WMS.Core.ServiceRegistration;

namespace WMS.CompositionRoot
{
    public static class CompositionRoot
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.RegisterCore();
            services.RegisterAdapterQueue();
            services.RegisterAdapterSql();
        }
    }
}