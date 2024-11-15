

using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Infrastructure.Persistence.Repository;
using RestauranteApi.Infrastructure.Persistence.Contexts;

namespace ApiRestaurante.Infrastructure.Persistence.Repositories
{
    public class PlateIngredientRepository:GenericRepository<PlateIngredient>, IPlateIngredientRepository
    {
        private readonly PersistenceContext _dbContext;

        public PlateIngredientRepository(PersistenceContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
