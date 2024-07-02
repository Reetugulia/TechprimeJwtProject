using TechprimeJwtProject.Models;
using TechprimeJwtProject.Repository;

namespace TechprimeJwtProject.Service
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository repo;
        public CategoryServices(ICategoryRepository repo)
        {
            this.repo = repo;
        }
        public int AddCategory(Category category)
        {
            return repo.AddCategory(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return repo.GetAllCategories();
        }

        public Category GetCategoryById(int categoryid)
        {
            return repo.GetCategoryById(categoryid);
        }

        public Category GetCategoryByName(string categoryname)
        {
           return repo.GetCategoryByName(categoryname);
        }
    }
}
