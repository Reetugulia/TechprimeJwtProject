using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface ITypeServices
    {
        IEnumerable<Types> GetAllTypes();
        
        int AddType(Types type);
        Types Gettypesbyid(int type);
    }
}
