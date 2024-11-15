
using System.ComponentModel.DataAnnotations;


namespace ApiRestaurante.Core.Application.ViewModels.Ingredients
{
    public class IngredientViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
