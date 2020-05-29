using RxWeb.Core.Data;
using UserApp.BoundedContext.Main;

namespace UserApp.UnitOfWork.Main
{
    public class UserUow : BaseUow, IUserUow
    {
        public UserUow(IUserContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IUserUow : ICoreUnitOfWork { }
}


