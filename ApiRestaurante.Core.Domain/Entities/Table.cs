

using ApiRestaurante.Core.Domain.Enums;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Table 
    {
        public int Id { get; set; }

        public int Capacity { get; set; } 

        public string Description { get; set; } 

        public TableStatus Status { get; set; } 
    }
}
