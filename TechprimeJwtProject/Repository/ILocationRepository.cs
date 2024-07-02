using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetLocations();
        int Addlocation(Location location);
        Location GetLocationbyId(int id);
        Location GetLocationbyName(string id);
    }
}
