

using ApiRestaurante.Core.Application.Dtos.Account;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {

        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<string> ConfirmAccountAsync(string userId, string token);
       
        Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin);
        
        Task SignOutAsync();




    }
}
