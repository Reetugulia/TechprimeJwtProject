

using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface ITypeRepository
    {
        IEnumerable<Types> GetAllTypes();
        
        Types Gettypesbyid(int type);
        int AddType(Types type);
    }
}
