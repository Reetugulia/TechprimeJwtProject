using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Service
{
    public interface ICategoryServices
    {
        IEnumerable<Category> GetAllCategories();
        int AddCategory(Category category);
        Category GetCategoryById(int categoryid);
        Category GetCategoryByName(string categoryname);
    }
}
