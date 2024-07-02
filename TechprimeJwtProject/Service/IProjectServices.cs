using Microsoft.AspNetCore.Mvc;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface IProjectServices
    {
         Task<IEnumerable<ProjectDTO>> GetAllProjects();
       // IEnumerable<Project> GetAllProjects();
        int AddProject(Project project);
        int UpdateProject(Project project);
        int DeleteProject(int Id);

        Project GetProjectbyName(string name);
        Project GetProjectbyid(int id);
        IEnumerable<Status> GetStatuses();
        int Add(Status status);
      
        Task<ProjectCount> GetProjectCounts();
        
    }
}
