using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext db;
        public DepartmentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddDepartment(Department department)
        {
            int result = 0;
            db.department.Add(department);
            result=db.SaveChanges();
            return result;
        }

        public Department GetDepartmentById(int id)
        {
            var model=db.department.Find(id);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Department GetDepartmentByName(string name)
        {
            var model = db.department.Find(name);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Department> GetDepartments()
        {
          return db.department.ToList();
        }
    }
}
