using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class ReasonRepository : IReasonRepository
    {
        private readonly ApplicationDbContext db;
        public ReasonRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddReason(Reason reason)
        {
            int result = 0;
            db.reasons.Add(reason);
            result=db.SaveChanges();
            return result;
        }

        public IEnumerable<Reason> GetAllReasons()
        {
            return db.reasons.ToList();
        }

        public Reason GetReasonbyId(int reasonId)
        {
            var model=db.reasons.Find(reasonId);
            if(model!=null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Reason GetReasonbyName(string reasonName)
        {
            var model = db.reasons.Find(reasonName);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
