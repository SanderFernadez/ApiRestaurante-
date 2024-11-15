

using ApiRestaurante.Core.Application.ViewModels.Plates;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IPlateService : IGenericService<SavePlateViewModel,PlateViewModel, Plate>
    {
    }
}
