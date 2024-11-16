
using ApiRestaurante.Core.Application.Dtos.Account;
using ApiRestaurante.Core.Application.Helpers;
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.OrderPlates;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ApiRestaurante.Core.Application.Services
{
    public class OrderPlateService : GenericService<SaveOrderPlateViewModel, OrderPlateViewModel, OrderPlate>, IOrderPlateService
    {
        private readonly IOrderPlateRepository _orderPlateRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse userViewModel;

        public OrderPlateService(IOrderPlateRepository orderPlateRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(orderPlateRepository, mapper)
        {
            _orderPlateRepository = orderPlateRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }
    }
}
