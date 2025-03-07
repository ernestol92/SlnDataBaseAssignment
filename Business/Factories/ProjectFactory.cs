using Business.Dtos;
using Business.Interfaces;
using Data.Entities;

namespace Business.Factories;

public class ProjectFactory : IProjectFactory
{
    public ProjectDTO CreateProjectDTO(ProjectEntity projectEntity)
    {
        return new ProjectDTO
        {
            Id = projectEntity.Id,
            ProjectName = projectEntity.ProjectName,
            StartDate = projectEntity.StartDate,
            EndDate = projectEntity.EndDate,
            ProjectManagerName = $"{projectEntity.Employee?.FirstName} {projectEntity.Employee?.LastName}",
            CustomerName = projectEntity.Customer.BusinessName,
            ServiceName = projectEntity.Service.ServiceName,
            PaymentStatus = projectEntity.Payment.PaymentStatus.PaymentStatus,
            Status = projectEntity.Status.Status
        };
    }


    public IEnumerable<ProjectDTO> ProjectDTOs(IEnumerable<ProjectEntity> projectEntities) 
    {
        return projectEntities.Select(CreateProjectDTO);
    }
}
