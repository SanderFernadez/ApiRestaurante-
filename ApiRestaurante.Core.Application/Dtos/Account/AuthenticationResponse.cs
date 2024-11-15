﻿

namespace ApiRestaurante.Core.Application.Dtos.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsVerified { get; set; }

       
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

       

        public List<string> Roles { get; set; } = new List<string>();
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
