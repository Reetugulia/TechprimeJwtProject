using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface IDivisionRepository
    {
        IEnumerable<Division> GetDivisions();
        int AddDivision(Division division);
        Division GetDivisionById(int id);
        Division GetDivisionbyName(string name);
    }
}
