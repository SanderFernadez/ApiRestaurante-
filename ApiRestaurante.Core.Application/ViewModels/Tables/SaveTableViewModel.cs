

using ApiRestaurante.Core.Domain.Enums;

namespace RestauranteApi.Core.Application.ViewModels.Tables
{
    public class SaveTableViewModel
    {
        public int Id { get; set; }

        public int Capacity { get; set; } 

        public string Description { get; set; }

        public TableStatus Status { get; set; }
    }
}
