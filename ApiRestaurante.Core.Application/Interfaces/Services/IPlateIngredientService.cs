

using ApiRestaurante.Core.Application.ViewModels.PlateIngredients;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IPlateIngredientService : IGenericService<SavePlateIngredientViewModel, PlateIngredientViewModel,PlateIngredient>    
    {
    }
}
