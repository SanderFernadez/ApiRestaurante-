using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Domain.Entities;
using ApiRestaurante.Infrastructure.Persistence.Repository;
using RestauranteApi.Infrastructure.Persistence.Contexts;

namespace ApiRestaurante.Infrastructure.Persistence.Repositories
{
    public class IngredientRepository : GenericRepository<Ingredient>, IIngredientepository
    {
        private readonly PersistenceContext _dbContext;

        public IngredientRepository(PersistenceContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}