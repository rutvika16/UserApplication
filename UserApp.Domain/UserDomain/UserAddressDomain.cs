using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using UserApp.UnitOfWork.Main;
using UserApp.Models.Main;

namespace UserApp.Domain.UserModule
{
    public class UserAddressDomain : IUserAddressDomain
    {
        public UserAddressDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(UserAddress parameters)
        {
            return await Uow.Repository<UserAddress>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
        }

        public async Task<object> GetBy(UserAddress parameters)
        {
            return await Uow.Repository<UserAddress>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
        }
        

        public HashSet<string> AddValidation(UserAddress entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserAddress entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserAddress entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserAddress entity)
        {
            var user = await Uow.Repository<UserAddress>().FindByAsync(t => t.AppUserId == entity.AppUserId);
            if (user != null)
            {
                await Uow.RegisterDirtyAsync(entity);
                await Uow.CommitAsync();
            }

        }

        public HashSet<string> DeleteValidation(UserAddress parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(UserAddress parameters)
        {
            var user = await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
            await Uow.RegisterDeletedAsync(user);
            await Uow.CommitAsync();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserAddressDomain : ICoreDomain<UserAddress, UserAddress> { }
}
