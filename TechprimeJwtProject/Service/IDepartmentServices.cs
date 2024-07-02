using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface IDepartmentServices
    {
        IEnumerable<Department> GetDepartments();
        int AddDepartment(Department department);
        Department GetDepartmentById(int id);
        Department GetDepartmentByName(string name);
    }
}
