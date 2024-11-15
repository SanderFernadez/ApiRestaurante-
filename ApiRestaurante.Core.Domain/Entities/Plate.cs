

using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Plate 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Servings { get; set; } // Cantidad de personas para las que da el plato

        public PlateCategory Category { get; set; } 

        public ICollection<PlateIngredient> PlateIngredients { get; set; }
    }
}
