﻿using Microsoft.EntityFrameworkCore;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Persistance.Contexs;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base
{
    public class GenericRepositoryBase<T> : IGenericRepository<T> where T : class
    {
        private readonly ShoppingListDbContext _dbContext;

        public GenericRepositoryBase(ShoppingListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await _dbContext.AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
