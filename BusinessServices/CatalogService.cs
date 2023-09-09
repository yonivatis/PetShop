using PetShopProject.Models;
using PetShopProject.Repositories;

namespace PetShopProject.BusinessServices
{
    public class CatalogService : ICatalogService
    {
        private readonly IRepository _repository;
        public CatalogService(IRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<Animal> GetAnimalByCategoryId(int id=1)
        {
            return _repository.GetAnimals().Where(a => a.CategoryId == id);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _repository.GetAnimals();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _repository.GetCategories();
        }

        public Category getCategory(int id)
        {
            return _repository.GetCategories().Single(c => c.CategoryId == id);
        }
    }
}
