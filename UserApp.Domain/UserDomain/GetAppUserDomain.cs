using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using UserApp.UnitOfWork.Main;
using UserApp.Models.Main;

namespace UserApp.Domain.UserModule
{
    public class GetAppUserDomain : IGetAppUserDomain
    {
        public GetAppUserDomain(IUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(AppUser parameters)
        {
            return await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
        }

        public async Task<object> GetBy(AppUser parameters)
        {
            return await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
        }
            public HashSet<string> AddValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(AppUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(AppUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(AppUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(AppUser parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IGetAppUserDomain : ICoreDomain<AppUser, AppUser> { }
}
