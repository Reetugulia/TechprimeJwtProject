using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class TypeServices : ITypeServices
    {
        private readonly ITypeRepository repo;
        public TypeServices(ITypeRepository repo)
        {
            this.repo = repo;
        }
        public int AddType(Types types)
        {
            return repo.AddType(types);
        }

        public IEnumerable<Types> GetAllTypes()
        {
            return repo.GetAllTypes();
        }

        public Types Gettypesbyid(int type)
        {
            return repo.Gettypesbyid(type);
        }
    }
}
