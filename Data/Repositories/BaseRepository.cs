using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Data.Repositories;

public abstract class BaseRepository<TEntity>(MyDBContext context) : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly MyDBContext _context = context;
    protected readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        if (entity == null) { return null!; }

        try
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"error creating project entity{ex.Message}");
            return null!;
        }
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        if (expression == null) { return null!; }

        return await _dbSet.FirstOrDefaultAsync(expression) ?? null!;
    }

    public async Task<TEntity> UpdateAsync(int id, TEntity updatedEntity)
    {
        if (updatedEntity == null) { return null!; }

        try
        {
            var existingEntity = await _dbSet.FindAsync(id);
            if (existingEntity == null) return null!;

            _context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
            await _context.SaveChangesAsync();
            return updatedEntity;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"error updating project entity{ex.Message}");
            return null!;
        }

    }

    public async Task<bool> DeleteAsync(int id)
    {

        try
        {
            var existingEntity = await _dbSet.FindAsync(id);
            if (existingEntity == null) return false;

            _dbSet.Remove(existingEntity);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception ex)
        {

            Debug.WriteLine($"error updating project entity :: {ex.Message}");
            return false!;
        }
    }
}
