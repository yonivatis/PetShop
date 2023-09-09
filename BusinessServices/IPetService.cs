using PetShopProject.Models;

namespace PetShopProject.BusinessServices
{
    public interface IPetService
    {
        public Animal GetAnimal(int animalId);
        public void AddComment(string comment, int animalId);

        public IEnumerable<Category> Categories();

        public void AddAnimal(Animal newAnimal);
        public void UpdateAnimal(Animal updateAnimal);
        public void RemoveAnimal(int animalId);

        public void AddCategory(Category newCategory); 

    }
}
