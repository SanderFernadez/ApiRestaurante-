
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Infrastructure.Persistence.Repository;
using RestauranteApi.Infrastructure.Persistence.Contexts;

namespace ApiRestaurante.Infrastructure.Persistence.Repositories
{
    public class PlateRepository: GenericRepository<Plate>, IPlateRepository
    {
        private readonly PersistenceContext _dbContext;

        public PlateRepository(PersistenceContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
