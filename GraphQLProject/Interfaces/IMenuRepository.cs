using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenu();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu, int id);
        void DeleteMenu(int id);
    }
}
