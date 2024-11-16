using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Helpers;
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.Ingredients;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ApiRestaurante.Core.Application.Services
{
    
        public class IngredientService : GenericService<SaveIngredientViewModel, IngredientViewModel, Ingredient>, IIngredientService
        {
            private readonly IIngredientpository _ingredientRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IMapper _mapper;
            private readonly AuthenticationResponse userViewModel;

            public IngredientService(IIngredientpository ingredientRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(ingredientRepository, mapper)
            {
                _ingredientRepository = ingredientRepository;
                _httpContextAccessor = httpContextAccessor;
                _mapper = mapper;
                userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            }
        
    }
}
