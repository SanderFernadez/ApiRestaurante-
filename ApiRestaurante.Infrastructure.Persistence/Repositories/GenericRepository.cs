﻿using ApiRestaurante.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using RestauranteApi.Infrastructure.Persistence.Contexts;


namespace ApiRestaurante.Infrastructure.Persistence.Repository
{
    //Generics
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private readonly PersistenceContext _dbContext;

        public GenericRepository(PersistenceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Entity> AddAsync(Entity entity)
        {
            await _dbContext.Set<Entity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<List<Entity>> AddRangeAsync(List<Entity> entities)
        {
            await _dbContext.Set<Entity>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
            return entities;
        }

        public virtual async Task UpdateAsync(Entity entity, int id)
        {
            var entry = await _dbContext.Set<Entity>().FindAsync(id);
            _dbContext.Entry(entry).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Entity entity)
        {
            _dbContext.Set<Entity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<List<Entity>> GetAllListAsync()
        {
            return await _dbContext.Set<Entity>().ToListAsync();//Deferred execution
        }

        public virtual IQueryable<Entity> GetAllQuery()
        {
            return _dbContext.Set<Entity>().AsQueryable();
        }

        public virtual async Task<List<Entity>> GetAllListWithIncludeAsync(List<string> properties)
        {
            var query = _dbContext.Set<Entity>().AsQueryable();

            foreach (string property in properties)
            {
                query = query.Include(property);
            }

            return await query.ToListAsync();
        }

        public virtual IQueryable<Entity> GetAllQueryWithInclude(List<string> properties)
        {
            var query = _dbContext.Set<Entity>().AsQueryable();

            foreach (string property in properties)
            {
                query = query.Include(property);
            }

            return query.AsQueryable();
        }

        public virtual async Task<Entity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Entity>().FindAsync(id);
        }
    }
}
