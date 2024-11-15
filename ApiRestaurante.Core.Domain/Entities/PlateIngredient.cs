

namespace ApiRestaurante.Core.Domain.Entities
{
    public class PlateIngredient
    {
        public int PlateId { get; set; }
        public Plate Plate { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
