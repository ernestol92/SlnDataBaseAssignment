using Business.Dtos;
using Business.Interfaces;
using Data.Entities;

namespace Business.Factories;

public class ProjectFactory : IProjectFactory
{
    public ProjectDTO CreateProjectDTO(ProjectEntity projectEntity)
    {
        if (projectEntity == null)
        {
            throw new ArgumentNullException(nameof(projectEntity), "Project entity cannot be null.");
        }


        return new ProjectDTO
        {
            Id = projectEntity.Id,
            ProjectName = projectEntity.ProjectName,
            StartDate = projectEntity.StartDate,
            EndDate = projectEntity.EndDate,
            ProjectManagerName = projectEntity.Employee != null ? $"{projectEntity.Employee?.FirstName} {projectEntity.Employee?.LastName}" : "N/A",
            CustomerName = projectEntity.Customer?.BusinessName ?? "N/A",
            ServiceName = projectEntity.Service?.ServiceName ?? "N/A",
            PaymentStatus = projectEntity.Payment?.PaymentStatus.PaymentStatus ?? "N/A",
            Status = projectEntity.Status?.Status ?? "N/A"
        };
    }


    public IEnumerable<ProjectDTO> ProjectDTOs(IEnumerable<ProjectEntity> projectEntities) 
    {
        return projectEntities.Select(CreateProjectDTO);
    }
}
