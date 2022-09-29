using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> LoginAsync(SignInModel signInModel);
        Task LogoutAsync();
        Task<IdentityResult> ChangeYourPassword(ChangePasswordModel model);
    }
}