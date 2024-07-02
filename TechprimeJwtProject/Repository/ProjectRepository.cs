using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext db;
        public ProjectRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProject(Project project)
        {
            int result = 0;
            project.StatusId = 1;
            db.projects.Add(project);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteProject(int id)
        {
            int result = 0;
            var model = db.projects.Where(x => x.Id == id).FirstOrDefault();
            if(model!= null)
            {
                db.projects.Remove(model);
                result= db.SaveChanges();

            }
            return result;
        }


        //public async Task<IEnumerable<Project>> GetAllProjects()
        //{

        //    var result = from project in db.projects
        //                 join reason in db.reasons on project.ReasonId equals reason.Reasonid
        //                 join type in db.types on project.TypeId equals type.Typeid
        //                 join division in db.divisions on project.DivisionId equals division.Divisionid
        //                 join department in db.department on project.DepartmentId equals department.Departmentid
        //                 join priority in db.priority on project.PriorityId equals priority.Priorityid
        //                 join category in db.categories on project.CategoryId equals category.Categoryid
        //                 join location in db.location on project.LocationId equals location.Locationid
        //                 select new Project
        //                 {
        //                     Id = project.Id,
        //                     Projectname = project.Projectname,
        //                     Reason = reason,
        //                     Types = type,
        //                     Division = division,
        //                     Department = department,
        //                     Priority = priority,
        //                     Category = category,
        //                     Location = location,
        //                     status = project.status
        //                 };

        //    return await result.ToListAsync();
        //}
        //public IEnumerable<Project> GetAllProjects()
        //{
        //    return db.projects.ToList();
        //}


        public Project GetProjectbyid(int id)
        {
            return db.projects.Where(x => x.Id == id).FirstOrDefault();
        }

        public Project GetProjectbyName(string name)
        {
            return db.projects.Where(x => x.ProjectName.Contains(name)).SingleOrDefault();
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
           var x=await
                (from p in db.projects
                 join t in db.types on p.TypeId equals t.Typeid
                 join cat in db.categories on p.CategoryId equals cat.Categoryid
                 join pr in db.priority on p.PriorityId equals pr.Priorityid
                 join l in db.location on p.LocationId equals l.Locationid
                 join dep in db.department on p.DepartmentId equals dep.Departmentid
                 join div in db.divisions on p.DivisionId equals div.Divisionid
                 join r in db.reasons on p.ReasonId equals r.Reasonid
                 join s in db.status on p.StatusId equals s.Id
                 select new ProjectDTO
                 {
                     Id = p.Id,
                     Projectname=p.ProjectName,
                     typename=t.Typename,
                     reasonname=r.Reasonname,
                     categoryname=cat.Categoryname,
                     locationname=l.Locationname,
                     priorityname=pr.Priorityname,
                     divisionname=div.Divisionname,
                     departmentname=dep.Departmentname,
                     statusType=s.StatusType,

                     StartingDate=p.StartingDate,
                     EndingndDate=p.EndingndDate,



                 }).ToListAsync();
            return x;
            
        }

        public IEnumerable<Status> GetStatuses()
        {
            return db.status.ToList();
        }

        public int Add(Status status)
        {
            int result = 0;
            db.status.Add(status);
            result = db.SaveChanges();
            return result;
        }
        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await db.projects.FindAsync(id);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            db.projects.Update(project);
             await db.SaveChangesAsync();
        }
        public async Task<Status> GetStatusByIdAsync(int id)
        {
            return await db.status.FindAsync(id);
        }
      

        public int UpdateProject(Project project)
        {
            int result = 0;
            var model = db.projects.Where(p => p.Id == project.Id).FirstOrDefault();
            if (model != null)
            {
                model.StatusId = project.StatusId;
                result = db.SaveChanges();
            }
            return result;
        }

        public async Task<ProjectCount> GetProjectCounts()
        {
         
         ProjectCount pc=new ProjectCount();
            pc.Running=db.projects.Count(x=>x.StatusId==1);
            pc.Closed = db.projects.Count(x => x.StatusId == 4);
            pc.Cancelled = db.projects.Count(x => x.StatusId == 3);
            pc.Delayed=db.projects.Count(x=>x.StatusId == 1&&x.EndingndDate<DateTime.Today);
            pc.TotalProjects = db.projects.Count();
            return pc;

        }

       



        //public async Task<bool> SaveProjectAsync(ProjectDTO projectDto)
        //{

        //    var project = new Project
        //    {
        //        ProjectName = projectDto.Projectname,
        //        TypeId = (await db.types.FirstOrDefaultAsync(t => t.Typename == projectDto.typename))?.Typeid ?? 0,
        //        CategoryId = (await db.categories.FirstOrDefaultAsync(c => c.Categoryname == projectDto.categoryname))?.Categoryid ?? 0,
        //        PriorityId = (await db.priority.FirstOrDefaultAsync(p => p.Priorityname == projectDto.priorityname))?.Priorityid ?? 0,
        //        LocationId = (await db.location.FirstOrDefaultAsync(l => l.Locationname == projectDto.locationname))?.Locationid ?? 0,
        //        DepartmentId = (await db.department.FirstOrDefaultAsync(d => d.Departmentname == projectDto.departmentname))?.Departmentid ?? 0,
        //        DivisionId = (await db.divisions.FirstOrDefaultAsync(div => div.Divisionname == projectDto.divisionname))?.Divisionid ?? 0,
        //        ReasonId = (await db.reasons.FirstOrDefaultAsync(r => r.Reasonname == projectDto.reasonname))?.Reasonid ?? 0,
        //        status = projectDto.status
        //    };

        //    db.projects.Add(project);
        //    int changes = await db.SaveChangesAsync();
        //    return changes > 0;
        //}
    }
}
