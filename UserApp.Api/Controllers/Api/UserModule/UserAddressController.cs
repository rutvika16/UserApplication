using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserApp.UnitOfWork.Main;
using UserApp.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace UserApp.Api.Controllers.UserModule
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
	
	public class UserAddressController : BaseController<UserAddress,UserAddress,UserAddress>

    {
        public UserAddressController(IUserUow uow):base(uow) {}

    }
}
