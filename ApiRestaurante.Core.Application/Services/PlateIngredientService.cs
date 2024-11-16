

using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Helpers;
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.PlateIngredients;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ApiRestaurante.Core.Application.Services
{
    public class PlateIngredientService : GenericService<SavePlateIngredientViewModel, PlateIngredientViewModel, PlateIngredient>, IPlateIngredientService
    {
        private readonly IPlateIngredientRepository _plateingredientRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse userViewModel;

        public PlateIngredientService(IPlateIngredientRepository plateingredientRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(plateingredientRepository, mapper)
        {
            _plateingredientRepository = plateingredientRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }
    }
}
