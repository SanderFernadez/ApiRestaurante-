

using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Infrastructure.Persistence.Repository;
using RestauranteApi.Infrastructure.Persistence.Contexts;

namespace ApiRestaurante.Infrastructure.Persistence.Repositories
{
    public class OrderPlateRepository: GenericRepository<OrderPlate>, IOrderPlateRepository
    {
        private readonly PersistenceContext _dbContext;

        public OrderPlateRepository(PersistenceContext dbContext) : base(dbContext) { 
        
        
        }
    }
}
