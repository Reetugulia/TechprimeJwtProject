using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class ReasonServices : IReasonServices
    {
        private readonly IReasonRepository repo;
        public ReasonServices(IReasonRepository repo)
        {
            this.repo = repo;
        }
        public int AddReason(Reason reason)
        {
            return repo.AddReason(reason);
        }

        public IEnumerable<Reason> GetAllReasons()
        {
           return repo.GetAllReasons();
        }

        public Reason GetReasonbyId(int reasonId)
        {
            return repo.GetReasonbyId(reasonId);
        }

        public Reason GetReasonbyName(string reasonName)
        {
           return repo.GetReasonbyName(reasonName);
        }
    }
}
