using Microsoft.EntityFrameworkCore;
using TechprimeJwtProject.Models;

namespace Techprime.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Types> types { get; set; }
        public DbSet<Reason> reasons { get; set; }

        public DbSet<Priority> priority { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Division> divisions { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Status> status { get; set; }
       public DbSet<ProjectCount> projectCount { get; set; }
        


    }

}
