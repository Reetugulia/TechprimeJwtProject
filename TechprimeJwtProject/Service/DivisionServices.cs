using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class DivisionServices : IDivisionServices
    {
        private readonly IDivisionRepository repo;
        public DivisionServices(IDivisionRepository repo)
        {
            this.repo = repo;
        }
        public int AddDivision(Division division)
        {
            return repo.AddDivision(division);
        }

        public Division GetDivisionById(int id)
        {
           return repo.GetDivisionById(id);
        }

        public Division GetDivisionbyName(string name)
        {
            return repo.GetDivisionbyName(name);
        }

        public IEnumerable<Division> GetDivisions()
        {
            return repo.GetDivisions();
        }
    }
}
