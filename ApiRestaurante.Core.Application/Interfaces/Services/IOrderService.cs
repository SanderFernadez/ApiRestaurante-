
using ApiRestaurante.Core.Application.ViewModels.Orders;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IOrderService : IGenericService<SaveOrderViewModel,OrderViewModel, Order>
    {
    }
}
