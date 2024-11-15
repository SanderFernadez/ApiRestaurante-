

using ApiRestaurante.Core.Application.ViewModels.Ingredients;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IIngredientService : IGenericService<SaveIngredientViewModel, IngredientViewModel, Ingredient>
    {
    }
}
