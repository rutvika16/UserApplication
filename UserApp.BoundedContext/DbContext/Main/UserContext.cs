using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserApp.BoundedContext.SqlContext;
using UserApp.Models.Main;
using UserApp.Models;
using UserApp.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace UserApp.BoundedContext.Main
{
    public class UserContext : BaseBoundedContext, IUserContext
    {
        public UserContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<UserAddress> UserAddress { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
            #endregion DbSets


    }


    public interface IUserContext : IDbContext
    {
    }
}

