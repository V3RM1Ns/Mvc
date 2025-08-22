using Microsoft.AspNetCore.Mvc;
using Practice.CarApp.Models;

namespace Practice.CarApp.Controllers
{
    public class MyModelController : Controller
    {
        private List<Model> models = new List<Model>
        {
            new Model { Id = 1, Name = "Model X", Description = "Electric SUV", BrandId = 1, Brand = new Brand { Id = 1, Name = "Tesla" } },
            new Model { Id = 2, Name = "Model Y", Description = "Compact Car", BrandId = 2, Brand = new Brand { Id = 2, Name = "Honda" } },
            new Model { Id = 3, Name = "Model Z", Description = "Sports Car", BrandId = 3, Brand = new Brand { Id = 3, Name = "Ford" } },
            
        };
        public IActionResult Index(int? brandId)
        {
            if (brandId.HasValue)
                return View(models.Where(m => m.BrandId == brandId.Value).ToList());

            return View(models);
        }
    }
}
