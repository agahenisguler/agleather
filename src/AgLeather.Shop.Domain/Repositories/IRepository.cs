using AgLeather.Shop.Domain.Common;
using System.Linq.Expressions;

namespace AgLeather.Shop.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<T> GetById(object id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(object id);
    }
}
