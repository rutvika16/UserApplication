using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using RxWeb.Core.Data;
using UserApp.UnitOfWork.Main;
using UserApp.Models.Main;
using UserApp.BoundedContext.SqlContext;
using Microsoft.Data.SqlClient;
using UserApp.Models.ViewModels;
using RxWeb.Core.Security.Cryptography;
using UserApp.Infrastructure.Security;



namespace UserApp.Domain.UserModule
{
    public class AppUserDomain : IAppUserDomain
    {
        private IPasswordHash PasswordHash { get; set; }
        private IApplicationTokenProvider ApplicationTokenProvider { get; set; }
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public AppUserDomain(IUserUow uow,IDbContextManager<MainSqlDbContext> dbContextManager , IPasswordHash passwordHash, IApplicationTokenProvider tokenProvider)
        {
            this.Uow = uow;
            PasswordHash = passwordHash;
            ApplicationTokenProvider = tokenProvider;
        }

        public async Task<object> GetAsync(AppUser parameters)
        {
            return await Uow.Repository<AppUser>().AllAsync();
        }

        public async Task<object> GetBy(AppUser parameters)
        {
            var result = await Uow.Repository<AppUser>().SingleOrDefaultAsync(t => t.UserName == parameters.UserName);
            if (result != null && PasswordHash.VerifySignature(parameters.userPassword, result.Password, result.Salt))
            {
                var token = await ApplicationTokenProvider.GetTokenAsync(result);
                result.token = token;
                return (result);
            }
            else
            {
                return await Task.FromResult("Try Again Please");
            }
            //throw new NotImplementedException();
        }


        public HashSet<string> AddValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(AppUser entity)
        {
            AppUser appuser = new AppUser();
            PasswordResult passwordResult = PasswordHash.Encrypt(entity.userPassword);
            appuser.FirstName = entity.FirstName;
            appuser.LastName = entity.LastName;
            appuser.UserName = entity.UserName;
            appuser.MobileNumber = entity.MobileNumber;
            appuser.EmailId = entity.EmailId;
            appuser.BirthDate = entity.BirthDate;
            appuser.Gender = entity.Gender;
            appuser.CreatedDateTime = entity.CreatedDateTime;
            appuser.UpdatedDateTime = entity.UpdatedDateTime;
            appuser.RoleId = entity.RoleId;
            appuser.Status = entity.Status;
            appuser.Password = passwordResult.Signature;
            appuser.Salt = passwordResult.Salt;
            await Uow.RegisterNewAsync(appuser);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(AppUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(AppUser entity)
        {
            var user = await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == entity.AppUserId);
            if (user != null)
            {
                await Uow.RegisterDirtyAsync(entity);
                await Uow.CommitAsync();
            }
                
        }

        public HashSet<string> DeleteValidation(AppUser parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(AppUser parameters)
        {
            var user = Uow.Repository<AppUser>().FirstOrDefault(t => t.AppUserId == parameters.AppUserId);
            await Uow.RegisterDeletedAsync(user);
            await Uow.CommitAsync();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();

    }

    public interface IAppUserDomain : ICoreDomain<AppUser, AppUser> { }
}
