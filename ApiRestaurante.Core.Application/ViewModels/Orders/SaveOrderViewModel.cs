

using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Application.ViewModels.Orders
{
    public class SaveOrderViewModel
    {
        public int Id { get; set; }

        public int MesaId { get; set; }
        

       
        public decimal Subtotal { get; set; }

      
        public OrderStatus Status { get; set; }

        
    }
}
