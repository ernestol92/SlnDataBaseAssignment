using Business.Interfaces;
using Data.Interfaces;
using System.Linq.Expressions;

namespace Business.Services;

public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
{
    private readonly IBaseRepository<TEntity> _repository;

    public BaseService(IBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        return await _repository.CreateAsync(entity);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _repository.GetAsync(expression);
    }

    public virtual async Task<TEntity> UpdateAsync(int id, TEntity updatedEntity)
    {
        return await _repository.UpdateAsync(id, updatedEntity);
    }

    public virtual async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}

