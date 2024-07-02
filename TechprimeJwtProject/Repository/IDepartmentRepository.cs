using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        int AddDepartment(Department department);
        Department GetDepartmentById(int id);
        Department GetDepartmentByName(string name);

    }
}
