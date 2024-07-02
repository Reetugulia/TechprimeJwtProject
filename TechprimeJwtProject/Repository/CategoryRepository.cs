using Techprime.Data;
using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddCategory(Category category)
        {
            int result = 0;
            db.categories.Add(category);
            result=db.SaveChanges();
            return result;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return db.categories.ToList();
        }

        public Category GetCategoryById(int categoryid)
        {
            var model=db.categories.Find(categoryid);
            if(model != null)
            {
                return model;
            }
            else
            {
                return null;
            }
        }

        public Category GetCategoryByName(string categoryname)
        {
            var model = db.categories.Find(categoryname);
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
