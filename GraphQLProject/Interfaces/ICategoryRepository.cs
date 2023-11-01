using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(Category category, int id);
        void DeleteCategory(int id);
    }
}
