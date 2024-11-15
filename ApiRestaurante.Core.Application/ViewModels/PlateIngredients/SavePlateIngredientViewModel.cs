
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.ViewModels.PlateIngredients
{
    public class SavePlateIngredientViewModel
    {
        public int PlateId { get; set; }
        public Plate Plate { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
