
using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Helpers;
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.Plates;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ApiRestaurante.Core.Application.Services
{
    public class PlateService : GenericService<SavePlateViewModel, PlateViewModel, Plate>, IPlateService
    {
        private readonly IPlateRepository _plateRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse userViewModel;

        public PlateService(IPlateRepository plateRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(plateRepository, mapper)
        {
            _plateRepository = plateRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }
    }
}
