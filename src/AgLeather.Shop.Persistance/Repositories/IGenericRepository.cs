using System.Linq.Expressions;

namespace AgLeather.Shop.Persistance.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        #region Read

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, params Expression<Func<T, object>>[] includes);


        #endregion


        #region Create, Update, Delete


        #endregion

    }

}