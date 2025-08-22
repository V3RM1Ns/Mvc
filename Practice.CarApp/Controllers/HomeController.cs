using Microsoft.AspNetCore.Mvc;
using Practice.CarApp.Models;

namespace Practice.CarApp.Controllers
{
    public class HomeController : Controller
    {
        private List<Brand> brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Toyota" },
            new Brand { Id = 2, Name = "Honda" },
            new Brand { Id = 3, Name = "Ford" }
        };
        public IActionResult Index()
        {
            return View(brands);
        }
    }
}
