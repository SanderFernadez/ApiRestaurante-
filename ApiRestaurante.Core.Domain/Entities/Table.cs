

using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Table 
    {
        public int Id { get; set; }

        public int Capacity { get; set; } // Cantidad de personas que puede tener la mesa

        public string Description { get; set; } 

        public TableStatus Status { get; set; } 
    }
}
