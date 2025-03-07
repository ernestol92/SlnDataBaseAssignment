using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Business.Dtos;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : BaseController<ProjectEntity>
{
    private readonly IProjectService _projectService;

    public ProjectController(IProjectService projectService) : base (projectService)
    {
        _projectService = projectService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectDTO>>> GetAllProjects()
    {
        var projects = await _projectService.GetAllProjectsDTOAsync();
        return Ok(projects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectDTO>> GetProject(int id)
    {
        var project = await _projectService.GetProjectDTOAsync(id);
        if(project == null) return NotFound();
        return Ok(project);
    }
}

