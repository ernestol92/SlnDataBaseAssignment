using Business.Dtos;
using Data.Entities;

namespace Business.Interfaces
{
    public interface IProjectFactory
    {
        public ProjectDTO CreateProjectDTO(ProjectEntity projectEntity);
        IEnumerable<ProjectDTO> ProjectDTOs(IEnumerable<ProjectEntity> projectEntities);
    }
}
