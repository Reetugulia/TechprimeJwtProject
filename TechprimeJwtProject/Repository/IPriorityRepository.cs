using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface IPriorityRepository
    {
        IEnumerable<Priority> GetPriorityList();
        int  AddPriority(Priority priority);
        Priority GetPriorityById(int priorityId);
        Priority GetPriorityByName(string name);
    }
}
