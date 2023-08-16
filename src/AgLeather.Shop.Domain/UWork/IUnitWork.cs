using AgLeather.Shop.Application.Repositories;
using AgLeather.Shop.Domain.Common;

namespace AgLeather.Shop.Domain.UWork
{
    public interface IUnitWork
    {
        public IRepository<T> GetRepository<T>() where T : BaseEntity;
        public Task<bool> CommitAsync();
    }
}
