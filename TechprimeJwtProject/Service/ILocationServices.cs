using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface ILocationServices
    {
        IEnumerable<Location> GetLocations();
        int Addlocation(Location location);
        Location GetLocationbyId(int id);
        Location GetLocationbyName(string id);
    }
}
