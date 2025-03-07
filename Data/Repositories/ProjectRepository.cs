using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class ProjectRepository(MyDBContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
}

