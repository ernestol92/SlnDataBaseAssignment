using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class ProjectRepository(MyDBContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        return await _dbSet
            .Include(p => p.Employee)
            .Include(p => p.Customer)
            .Include(p => p.Service)
            .Include(p => p.Payment).ThenInclude(p => p.PaymentStatus)
            .Include(p => p.Status)
            .ToListAsync();

    }

    public async Task<ProjectEntity?> GetByIdAsync(int projectId)
    {
        return await _dbSet
            .Include(p => p.Employee)
            .Include(p => p.Customer)
            .Include(p => p.Service)
            .Include(p => p.Payment).ThenInclude(p => p.PaymentStatus)
            .Include(p => p.Status)
            .FirstOrDefaultAsync(p => p.Id == projectId);
    }
}

