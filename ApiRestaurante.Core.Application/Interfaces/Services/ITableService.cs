

using ApiRestaurante.Core.Domain.Entities;
using RestauranteApi.Core.Application.ViewModels.Tables;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface ITableService : IGenericService<SaveTableViewModel, TableViewModel, Table>
    {
    }
}
