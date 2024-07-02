using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface IProjectRepository
    {
         Task<IEnumerable<ProjectDTO>> GetAllProjects();
        //IEnumerable<Project>GetAllProjects();
        int AddProject(Project project);
        int UpdateProject(Project project);
        int DeleteProject(int Id);

        Project GetProjectbyName(string name);
        Project GetProjectbyid(int id);

        IEnumerable<Status> GetStatuses();
        int Add(Status status);
        Task<Project> GetProjectByIdAsync(int id);
        Task UpdateProjectAsync(Project project);
        Task<Status> GetStatusByIdAsync(int id);
        Task<ProjectCount> GetProjectCounts();
        

            
        ///Task<bool> SaveProjectAsync(ProjectDTO projectDto);

    }
}
