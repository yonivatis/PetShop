using PetShopProject.Models;

namespace PetShopProject.Repositories
{
    public interface IRepository
    {
        IEnumerable<Animal> GetAnimals(); 
        IEnumerable<Comment> GetComments();
        IEnumerable<Category> GetCategories();
        void AddComment(Comment newComment);
        void AddAnimal(Animal newAnimal);
        void UpdateAnimal(Animal updateAnimal);
        void RemoveAnimal(int animalId);
        void AddCategory(Category newCategory);
    }
}
