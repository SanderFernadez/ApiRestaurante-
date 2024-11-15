

using ApiRestaurante.Core.Application.ViewModels.OrderPlates;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IOrderPlateService : IGenericService<SaveOrderPlateViewModel,OrderPlateViewModel,OrderPlate>
    {
    }
}
