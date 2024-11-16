
using System.ComponentModel.DataAnnotations;


namespace ApiRestaurante.Core.Application.ViewModels.Ingredients
{
    public class SaveIngredientViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
