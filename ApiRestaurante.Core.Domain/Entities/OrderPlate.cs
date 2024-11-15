

namespace ApiRestaurante.Core.Domain.Entities
{
    public class OrderPlate
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int PlateId { get; set; }
        public Plate Plate { get; set; }

        public int Quantity { get; set; }
    }
}
