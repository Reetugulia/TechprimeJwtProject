using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface IReasonRepository
    {
        IEnumerable<Reason> GetAllReasons();
        Reason GetReasonbyId(int reasonId);

        Reason GetReasonbyName(string reasonName);  

        int AddReason(Reason reason);
    }
}
