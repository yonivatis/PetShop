using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShopProject.BusinessServices;
using PetShopProject.Models;

namespace PetShopProject.Controllers
{
    [Authorize]
    public class CatalogController : Controller
    {
        private readonly ICatalogService _service;
        public CatalogController(ICatalogService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public IActionResult Index(int id=0)
        {
            ViewBag.Categories = _service.GetCategories();
            if(id == 0)
            {
                ViewBag.CurrentCategory = new Category { CategoryId = 0 , Name = "All Animals"};
                return View(_service.GetAnimals());
            }
            ViewBag.CurrentCategory = _service.getCategory(id);
            return View(_service.GetAnimalByCategoryId(id));
        }
    }
}
