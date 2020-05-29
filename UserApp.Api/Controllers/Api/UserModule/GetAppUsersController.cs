using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserApp.Domain.UserModule;
using UserApp.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace UserApp.Api.Controllers.UserModule
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
	
	public class GetAppUsersController : BaseDomainController<AppUser, AppUser>

    {
        public GetAppUsersController(IGetAppUserDomain domain):base(domain) {}

    }
}
