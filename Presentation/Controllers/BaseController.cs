using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.Interfaces;

namespace Presentation.Controllers;


[Route("api/[controller]")]
[ApiController]
public class BaseController<TEntity> : ControllerBase, IBaseController<TEntity> where TEntity : class, IEntity
{

    private readonly IBaseService<TEntity> _baseService;
    public BaseController(IBaseService<TEntity> baseService)
    {
        _baseService = baseService;
    }

    // GET: api/project
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> GetAllAsync()
    {
        var items = await _baseService.GetAllAsync();
        return Ok(items);
    }

    // GET: api/project/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TEntity>> GetAsync(int id)
    {
        if (id <= 0) return BadRequest();

        var item = await _baseService.GetAsync(x => x.Id == id);

        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    // POST: api/project
    [HttpPost]
    public async Task<ActionResult<TEntity>> CreateAsync(TEntity item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        // Call the service to create a new project
        var createdItem = await _baseService.CreateAsync(item);

        // Return the created project
        return CreatedAtAction(nameof(GetAsync), new { id = createdItem.Id }, createdItem);
    }

    // PUT: api/project/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, TEntity item)
    {
        if (item == null || item.Id != id || id <= 0)
        {
            return BadRequest();
        }

        // Call the service to update the project
        var updatedItem = await _baseService.UpdateAsync(id, item);

        return NoContent();
    }

    // DELETE: api/project/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        if (id <= 0) return BadRequest();

        var result = await _baseService.DeleteAsync(id);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
    

