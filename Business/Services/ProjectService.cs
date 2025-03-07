using Business.Dtos;
using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;

namespace Business.Services;

public class ProjectService : BaseService<ProjectEntity>, IProjectService
{
    private readonly IProjectFactory _projectFactory;
    private readonly IBaseRepository<ProjectEntity> _repository;
    public ProjectService(IBaseRepository<ProjectEntity> repository, IProjectFactory projectFactory) : base(repository)
    {
        _projectFactory = projectFactory;
        _repository = repository;
    }

    public async Task<IEnumerable<ProjectDTO>> GetAllProjectsDTOAsync()
    {
        var projects = await _repository.GetAllAsync();

        return _projectFactory.ProjectDTOs(projects);
    }

    public async Task<ProjectDTO> GetProjectDTOAsync(int id)
    {
        var project = await GetAsync(p => p.Id == id);
        return _projectFactory.CreateProjectDTO(project);
    }
}
