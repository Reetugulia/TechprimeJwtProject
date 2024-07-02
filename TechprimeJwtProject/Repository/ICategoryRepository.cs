using TechprimeJwtProject.Models;

namespace TechprimeJwtProject.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category>GetAllCategories();
        int AddCategory(Category category);
        Category GetCategoryById(int categoryid);
        Category GetCategoryByName(string categoryname);
    }
}
