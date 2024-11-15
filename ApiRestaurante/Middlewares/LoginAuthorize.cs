using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Enums;
using ApiRestaurante.Core.Application.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestaurante.Middlewares
{
   
        public class LoginAuthorize : IAsyncActionFilter
        {
            private readonly ValidateUserSession _userSession;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly AuthenticationResponse _userViewModel;

            public LoginAuthorize(ValidateUserSession userSession, IHttpContextAccessor httpContextAccessor)
            {
                _userSession = userSession;
                _httpContextAccessor = httpContextAccessor;
                _userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                // Verificar si el usuario tiene sesión activa
                if (_userSession.HasUser())
                {
                    // Comprobar el rol del usuario
                    if (_userViewModel.Roles.FirstOrDefault() == Roles.SuperAdmin.ToString())
                    {
                        // Redirigir al usuario con rol "Client" a la vista "Index" en "BankAccount"
                        context.Result = new RedirectToActionResult("Dashboard", "User", _userViewModel.Roles);
                    }


                    else if (_userViewModel.Roles.FirstOrDefault() == Roles.Waiter.ToString())
                    {
                        // Redirigir al usuario con rol "Client" a la vista "Index" en "BankAccount"
                        context.Result = new RedirectToActionResult("Index", "BankAccount", _userViewModel.Roles);
                    }


                    else
                    {
                        // Redirigir a otros usuarios a la vista "Dashboard" en "BankAccount"
                        context.Result = new RedirectToActionResult("Dashboard", "User", _userViewModel.Roles);
                    }
                }
                else
                {
                    // Continuar con la ejecución si no hay usuario en sesión
                    await next();
                }
            }

        }
    
}
