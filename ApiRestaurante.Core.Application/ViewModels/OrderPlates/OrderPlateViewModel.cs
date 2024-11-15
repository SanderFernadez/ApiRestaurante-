

using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.ViewModels.OrderPlates
{
    public class OrderPlateViewModel
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PlateId { get; set; }
        public Plate Plate { get; set; }
        public int Quantity { get; set; }

        //public string PlateName { get; set; }
        //public decimal PlatePrice { get; set; }
    }
}
