using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Interfaces
{
    public interface IBaseController<TEntity> where TEntity : class, IEntity
    {
        Task<ActionResult<TEntity>> CreateAsync(TEntity item);
        Task<IActionResult> DeleteAsync(int id);
        Task<ActionResult<IEnumerable<TEntity>>> GetAllAsync();
        Task<ActionResult<TEntity>> GetAsync(int id);
        Task<IActionResult> UpdateAsync(int id, TEntity item);
    }
}