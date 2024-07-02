using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext db;
        public LocationRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int Addlocation(Location location)
        {
            int result = 0;
            db.location.Add(location);
            result=db.SaveChanges();
            return result;  
        }

        public Location GetLocationbyId(int id)
        {
           var model=db.location.Find(id);
            if(model!=null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Location GetLocationbyName(string name)
        {
            var model = db.location.Find(name);
            if (model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Location> GetLocations()
        {
            return db.location.ToList();
        }
    }
}
