using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class ProjectRepository(MyDBContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
    private readonly MyDBContext _context = context;

}

////create
//public void AddProject (ProjectEntity project) 
//{
//    _context.Projects.Add(project);
//    _context.SaveChanges();
//}
////read
//public ProjectEntity? GetProjectById(int id) 
//{
//    var project = _context.Projects.Find(id);

//    if (project == null) { return null; }

//    return project;
//}
////update
//public void UpdateProject(ProjectEntity project) 
//{
//    _context.Projects.Update(project);
//    _context.SaveChanges();
//}
////delete
//public void DeleteProject(int id) 
//{
//    var project = _context.Projects.Find(id);
//    if (project != null) 
//    {
//        _context.Projects.Remove(project);
//    }

//}