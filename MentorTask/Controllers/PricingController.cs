using Microsoft.AspNetCore.Mvc;

namespace MentorTask.Controllers;

public class PricingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}