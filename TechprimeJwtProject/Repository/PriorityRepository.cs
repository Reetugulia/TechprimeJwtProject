using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly ApplicationDbContext db;

        public PriorityRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddPriority(Priority priority)
        {
            int result = 0;
            db.priority.Add(priority);
            result=db.SaveChanges();
            return result;

        }

        public Priority GetPriorityById(int priorityId)
        {
            var model=db.priority.Find(priorityId);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Priority GetPriorityByName(string name)
        {
            var model = db.priority.Find(name);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Priority> GetPriorityList()
        {
            return db.priority.ToList();
        }
    }
}
