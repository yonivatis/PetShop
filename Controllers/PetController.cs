using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShopProject.BusinessServices;
using PetShopProject.Models;

namespace PetShopProject.Controllers
{
    [Authorize]
    public class PetController : Controller
    {
        private readonly IPetService _service;
        public PetController(IPetService service)
        {
            _service = service;
        }
        [Route("Pet/Index/{id:int}")]
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            Animal showAnimal;
            try
            {
                showAnimal = _service.GetAnimal(id);
            }
            catch(NullReferenceException)
            {
                return Redirect("/Error");
            }
            return View(showAnimal);
            //return View(_service.GetAnimal(animalId));
        }
        [AllowAnonymous]
        public IActionResult AddComment(string comment, int animalId)
        {
            _service.AddComment(comment, animalId);
            return Redirect($"/Pet/Index/{animalId}");
        }
        [HttpGet]
        public IActionResult AddAnimal()
        {
            ViewBag.Categories = _service.Categories();
            return View();
        }
        [HttpPost]
        public IActionResult AddAnimal(Animal newAnimal)
        {
            _service.AddAnimal(newAnimal);
            return RedirectToAction("Index","Catalog", new {id = newAnimal.CategoryId});
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category newCategory)
        {
            _service.AddCategory(newCategory);
            return RedirectToAction("AddAnimal", "Pet");
        }
        [HttpPost]
        public IActionResult RemoveAnimal(int animalId)//Add Normal Redirection!!!
        {
            //var categoryId = _service.Get;
            _service.RemoveAnimal(animalId);
            return RedirectToAction("Index", "Catalog"/*, new { id = categoryId }*/);
        }
        [HttpPost]
        public IActionResult EditAnimal(int animalId)
        {
            ViewBag.Categories = _service.Categories();
            var animal = _service.GetAnimal(animalId);
            return View(animal);
        }
        [HttpPost]
        public IActionResult EditAnimalResult(Animal animal)
        {
            _service.UpdateAnimal(animal);
            return RedirectToAction("Index", "Catalog", new { id = animal.CategoryId });
        }
    }
}
