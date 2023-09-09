using PetShopProject.Models;
using PetShopProject.Repositories;

namespace PetShopProject.BusinessServices
{
    public class HomeService : IHomeService
    {
        private readonly IRepository _repository;
        public HomeService(IRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<Animal> MostPopularAnimals()
        {
            return _repository.GetAnimals().OrderByDescending(c => c.Comments!.Count).Take(2);
        }

    }
}
