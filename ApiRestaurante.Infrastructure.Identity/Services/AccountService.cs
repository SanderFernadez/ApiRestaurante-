

using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace ApiRestaurante.Infrastructure.Identity.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> ConfirmAccountAsync(string userId, string token)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }

       


    }
}
