using Business.Dtos;
using Data.Entities;

namespace Business.Interfaces;

public interface IProjectService : IBaseService<ProjectEntity>
{
    Task<IEnumerable<ProjectDTO>> GetAllProjectsDTOAsync();
    Task<ProjectDTO> GetProjectDTOAsync(int id);
}
