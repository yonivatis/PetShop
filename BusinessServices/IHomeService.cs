using PetShopProject.Models;

namespace PetShopProject.BusinessServices
{
    public interface IHomeService
    {
        //int[] MostComments();//returns array of animalsId Ordered by amout of comments
        //IEnumerable<int> MostPopular();
        IEnumerable<Animal> MostPopularAnimals();
    }
}
