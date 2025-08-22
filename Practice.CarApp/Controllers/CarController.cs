using Microsoft.AspNetCore.Mvc;
using Practice.CarApp.Models;

namespace Practice.CarApp.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Name = "Model S", Description = "Electric sedan", Price = 79999, ModelId = 1 },
            new Car { Id = 2, Name = "Model 3", Description = "Affordable electric car", Price = 39999, ModelId = 1 },
            new Car { Id = 3, Name = "Mustang", Description = "Classic muscle car", Price = 55999, ModelId = 2 },
            new Car { Id = 4, Name = "F-150", Description = "Popular pickup truck", Price = 28999, ModelId = 3 },
            new Car { Id = 5, Name = "Civic", Description = "Reliable compact car", Price = 21999, ModelId = 4 },
            new Car { Id = 6, Name = "Accord", Description = "Midsize sedan", Price = 24999, ModelId = 4 },
            
        };
        public IActionResult Index(int? modelId)
        {
            if (modelId.HasValue)
                return View(cars.Where(c => c.ModelId == modelId.Value).ToList());

            return View(cars);
        }
        public IActionResult Detail(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
                return NotFound();

            return View(car);
        }
    }
}
