using Microsoft.AspNetCore.Mvc;
using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class ProjectServices : IProjectServices
    {
        private readonly IProjectRepository repo;
        public ProjectServices(IProjectRepository repo)
        {
            this.repo = repo;
        }

        public int Add(Status status)
        {
            return repo.Add(status);
        }

        public int AddProject(Project project)
        {
            return repo.AddProject(project);
        }

        public int DeleteProject(int Id)
        {
            return repo.DeleteProject(Id);
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
            return await repo.GetAllProjects();
        }

       

        public Project GetProjectbyid(int id)
        {
            return repo.GetProjectbyid(id);
        }

        public Project GetProjectbyName(string name)
        {
            return repo.GetProjectbyName(name);
        }

        public Task<ProjectCount> GetProjectCounts()
        {
            return  repo.GetProjectCounts();
        }

        public IEnumerable<Status> GetStatuses()
        {
            return repo.GetStatuses();
        }

        public int UpdateProject(Project project)
        {
            return repo.UpdateProject(project);
        }

        public async Task<bool> UpdateProjectStatusAsync(int projectId, int statusId)
        {
            var project = await repo.GetProjectByIdAsync(projectId);
            if (project == null)
            {
                return false;
            }

            var status = await repo.GetStatusByIdAsync(statusId);
            if (status == null)
            {
                return false;
            }

            project.StatusId = statusId;
          //  project.Status = status;

            await repo.UpdateProjectAsync(project);
            return true;
        }

        //public  Task<bool> SaveProjectAsync(ProjectDTO projectDto)
        //{
        //    return repo.SaveProjectAsync(projectDto);
        //}

        //public int UpdateProject(Project project)
        //{
        //    return repo.UpdateProject(project);
        //}
    }
}
