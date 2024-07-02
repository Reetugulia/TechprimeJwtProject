using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface IReasonServices
    {
        IEnumerable<Reason> GetAllReasons();
        Reason GetReasonbyId(int reasonId);

        Reason GetReasonbyName(string reasonName);

        int AddReason(Reason reason);
    }
}
