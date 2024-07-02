using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class DivisionRepository : IDivisionRepository
    {
        private readonly ApplicationDbContext db;
        public DivisionRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddDivision(Division division)
        {
            int result = 0;
            db.divisions.Add(division);
            result=db.SaveChanges();
            return result;
            
        }

        public Division GetDivisionById(int id)
        {
            var model=db.divisions.Find(id);
            if(model!=null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Division GetDivisionbyName(string name)
        {
            var model = db.divisions.Find(name);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Division> GetDivisions()
        {
            return db.divisions.ToList();
        }
    }
}
