using PetShopProject.Models;

namespace PetShopProject.BusinessServices
{
    public interface IAdminService
    {
        IEnumerable<Category> GetCategories();
        Category getCategory(int id);
        IEnumerable<Animal> GetAnimalByCategoryId(int id = 1);
    }
}
