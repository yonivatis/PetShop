using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShopProject.BusinessServices;

namespace PetShopProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeService _service;
        public HomeController(IHomeService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_service.MostPopularAnimals());
        }
    }
}
