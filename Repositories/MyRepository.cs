using PetShopProject.Data;
using PetShopProject.Models;

namespace PetShopProject.Repositories
{
    public class MyRepository : IRepository
    {
        private PetShopContext _context;
        public MyRepository(PetShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _context.Animals!;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories!;
        }

        public IEnumerable<Comment> GetComments()
        {
            return _context.Comments!;
        }
        public void AddComment(Comment newComment)
        {
            _context.Comments!.Add(newComment);
            _context.SaveChanges();
        }

        public void AddAnimal(Animal newAnimal)
        {
            _context.Animals!.Add(newAnimal);
            _context.SaveChanges();
        }
        public void RemoveAnimal(int animalId)
        {
            var animalInDb = _context.Animals!.SingleOrDefault(a => a.AnimalId == animalId);
            _context.Animals!.Remove(animalInDb!);
            _context.SaveChanges();
        }

        public void UpdateAnimal(Animal updateAnimal)
        {
            _context.Animals!.Update(updateAnimal);
            _context.SaveChanges();
        }

        public void AddCategory(Category newCategory)
        {
            _context.Categories!.Add(newCategory);
            _context.SaveChanges();
        }
    }
}
