using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepository repo;
        public DepartmentServices(IDepartmentRepository repo)
        {
            this.repo = repo;
        }

        public int AddDepartment(Department department)
        {
            return repo.AddDepartment(department);
        }

        public Department GetDepartmentById(int id)
        {
           return repo.GetDepartmentById(id);
        }

        public Department GetDepartmentByName(string name)
        {
            return repo.GetDepartmentByName(name);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return repo.GetDepartments();
        }
    }
}
