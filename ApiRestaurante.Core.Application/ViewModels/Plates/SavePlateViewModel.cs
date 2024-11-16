
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Core.Domain.Enums;



namespace ApiRestaurante.Core.Application.ViewModels.Plates
{
    public class SavePlateViewModel
    {
        public int Id { get; set; }

        
       
        public string Name { get; set; }

      
        public decimal Price { get; set; }

    
        public int Servings { get; set; }

        public PlateCategory Category { get; set; }

        public ICollection<PlateIngredient> PlateIngredients { get; set; }
    }
}
