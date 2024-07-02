using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface IDivisionServices
    {
        IEnumerable<Division> GetDivisions();
        int AddDivision(Division division);
        Division GetDivisionById(int id);
        Division GetDivisionbyName(string name);
    }
}
