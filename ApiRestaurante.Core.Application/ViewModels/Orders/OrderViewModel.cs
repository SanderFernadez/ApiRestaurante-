
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Application.ViewModels.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int MesaId { get; set; }
        public Table Mesa { get; set; }

        
        public decimal Subtotal { get; set; }

    
        public OrderStatus Status { get; set; }

        public ICollection<OrderPlate> OrderPlate { get; set; }
    }

}
