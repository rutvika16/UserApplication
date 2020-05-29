using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using UserApp.UnitOfWork.Main;
using UserApp.Models.Main;
using RxWeb.Core.Security.Cryptography;
using UserApp.Infrastructure.Security;

namespace UserApp.Domain.UserModule
{
    public class ForgotPasswordDomain : IForgotPasswordDomain
    {
        private IPasswordHash PasswordHash { get; set; }
        private IApplicationTokenProvider ApplicationTokenProvider { get; set; }

        public ForgotPasswordDomain(IUserUow uow, IPasswordHash passwordHash, IApplicationTokenProvider tokenProvider)
        {
            this.Uow = uow;
            PasswordHash = passwordHash;
            ApplicationTokenProvider = tokenProvider;
        }

        public async Task<object> GetAsync(AppUser parameters)
        {
            return await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == parameters.AppUserId);
        }

        public async Task<object> GetBy(AppUser parameters)
        {
            
            var result = await Uow.Repository<AppUser>().SingleOrDefaultAsync(t => t.EmailId == parameters.EmailId);
            if (result != null)
            {
                var token = await ApplicationTokenProvider.GetTokenAsync(result);
                result.token = token;
                return (result);
               // return await Task.FromResult("Successfully Verified");
            }
            else
            {
                return await Task.FromResult("Enter Correct Email Id");
            }
            //throw new NotImplementedException();
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
            var user = await Uow.Repository<AppUser>().FindByAsync(t => t.AppUserId == entity.AppUserId);
            if(user!=null)
            {
                PasswordResult result = PasswordHash.Encrypt(entity.userPassword);
                entity.Password = result.Signature;
                entity.Salt = result.Salt;
                await Uow.RegisterDirtyAsync(entity);
                await Uow.CommitAsync();
            }            
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

    public interface IForgotPasswordDomain : ICoreDomain<AppUser, AppUser> { }
}
