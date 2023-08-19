using AgLeather.Shop.Application.Repositories;
using AgLeather.Shop.Domain.Common;
using AgLeather.Shop.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgLeather.Shop.Persistance.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : BaseEntity
        
    {
        private readonly AgLeatherContext _dbContext;
        public Repository(AgLeatherContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbContext.Set<T>());
        }

        public async Task<IQueryable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await Task.FromResult(_dbContext.Set<T>().Where(filter));
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().AnyAsync(filter);
        }
        public async Task<T> GetById(object id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            return entity;
        }
        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();


        }
        public async Task Update(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();

        }

        public async Task Delete(object id)
        {
            await _dbContext.Set<T>().FindAsync(id);
            await _dbContext.SaveChangesAsync();

        }

     
    }
}
