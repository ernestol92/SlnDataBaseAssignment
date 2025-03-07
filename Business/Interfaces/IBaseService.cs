using System.Linq.Expressions;

namespace Business.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class 
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> UpdateAsync(int id, TEntity updatedEntity);
    }
}