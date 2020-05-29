using Microsoft.Extensions.DependencyInjection;
using UserApp.Infrastructure.Singleton;
using UserApp.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace UserApp.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




