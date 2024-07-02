using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class PriorityServices : IPriorityServices
    {
        private readonly IPriorityRepository repo;
        public PriorityServices(IPriorityRepository repo)
        {
            this.repo = repo;
        }
        public int AddPriority(Priority priority)
        {
           return repo.AddPriority(priority);
        }

        public Priority GetPriorityById(int priorityId)
        {
            return repo.GetPriorityById(priorityId);
        }

        public Priority GetPriorityByName(string name)
        {
            return repo.GetPriorityByName(name);
        }

        public IEnumerable<Priority> GetPriorityList()
        {
            return repo.GetPriorityList();
        }
    }
}
