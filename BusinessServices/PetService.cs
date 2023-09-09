using PetShopProject.Models;
using PetShopProject.Repositories;

namespace PetShopProject.BusinessServices
{
    public class PetService : IPetService
    {
        private readonly IRepository _service;
        public PetService(IRepository service)
        {
            _service = service;
        }

        public void AddAnimal(Animal newAnimal)
        {
            _service.AddAnimal(newAnimal);
        }

        public void AddCategory(Category newCategory)
        {
            _service.AddCategory(newCategory);
        }

        public void AddComment(string comment,int animalId)
        {
            _service.AddComment(new Comment { AnimalId = animalId, CommentText = comment });
        }

        public IEnumerable<Category> Categories()
        {
            return _service.GetCategories();
        }

        public Animal GetAnimal(int animalId)
        {
            return _service.GetAnimals().SingleOrDefault(a => a.AnimalId == animalId)!;
        }

        public void RemoveAnimal(int animalId)
        {
            _service.RemoveAnimal(animalId);
        }

        public void UpdateAnimal(Animal updateAnimal)
        {
            _service.UpdateAnimal(updateAnimal);
        }
    }
}
