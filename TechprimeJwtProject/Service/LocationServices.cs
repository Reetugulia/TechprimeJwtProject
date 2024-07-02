using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class LocationServices : ILocationServices
    {
        private readonly ILocationRepository repo;
        public LocationServices(ILocationRepository repo)
        {
            this.repo = repo;
        }
        public int Addlocation(Location location)
        {
           return repo.Addlocation(location);
        }

        public Location GetLocationbyId(int id)
        {
            return repo.GetLocationbyId(id);
        }

        public Location GetLocationbyName(string name)
        {
           return repo.GetLocationbyName(name);
        }

        public IEnumerable<Location> GetLocations()
        {
           return repo.GetLocations();
        }
    }
}
