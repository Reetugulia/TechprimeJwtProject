

using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class TypeRepository : ITypeRepository
    {
        private readonly ApplicationDbContext db;
        public TypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }


        public int AddType(Types type)
        {
            int result = 0;
            db.types.Add(type);
            result = db.SaveChanges();
            return result;
        }

        public IEnumerable<Types> GetAllTypes()
        {
            return db.types.ToList();
        }

        public Types Gettypesbyid(int type)
        {
            var model = db.types.Find(type);
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