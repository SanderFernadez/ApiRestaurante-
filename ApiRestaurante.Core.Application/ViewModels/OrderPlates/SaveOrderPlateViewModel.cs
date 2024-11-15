

using ApiRestaurante.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApiRestaurante.Core.Application.ViewModels.OrderPlates
{
    public class SaveOrderPlateViewModel
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PlateId { get; set; }
        public Plate Plate { get; set; }

        
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1")]
        public int Quantity { get; set; }
    }
}
