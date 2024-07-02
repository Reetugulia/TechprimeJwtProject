using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface IPriorityServices
    {
        IEnumerable<Priority> GetPriorityList();
        int AddPriority(Priority priority);
        Priority GetPriorityById(int priorityId);
        Priority GetPriorityByName(string name);
    }
}
