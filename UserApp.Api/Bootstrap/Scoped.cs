#region Namespace
using Microsoft.Extensions.DependencyInjection;
using UserApp.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using UserApp.UnitOfWork.DbEntityAudit;
using UserApp.BoundedContext.Main;
using UserApp.UnitOfWork.Main;
using UserApp.Domain.UserModule;
            #endregion Namespace




namespace UserApp.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IUserContext, UserContext>();
            serviceCollection.AddScoped<IUserUow, UserUow>();
            #endregion ContextService




            #region DomainService

            
            serviceCollection.AddScoped<IAppUserDomain, AppUserDomain>();
            
            serviceCollection.AddScoped<IForgotPasswordDomain, ForgotPasswordDomain>();
            
            serviceCollection.AddScoped<IUserAddressDomain, UserAddressDomain>();
            
            serviceCollection.AddScoped<IGetAppUserDomain, GetAppUserDomain>();
            #endregion DomainService




        }
    }
}




