


using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Order 
    {
        public int Id { get; set; }

        public int MesaId { get; set; }
        public Table Mesa { get; set; }

        public decimal Subtotal { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<OrderPlate> OrderPlate { get; set; }
    }
}
