using PetShopProject.Models;

namespace PetShopProject.BusinessServices
{
    public interface ICatalogService
    {
        IEnumerable<Category> GetCategories();
        Category getCategory(int id);
        IEnumerable<Animal> GetAnimalByCategoryId(int id=1);
        IEnumerable<Animal> GetAnimals();
    }
}
