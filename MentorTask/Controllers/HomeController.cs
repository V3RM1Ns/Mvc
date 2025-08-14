using MentorTask.Data;
using Microsoft.AspNetCore.Mvc;
using MentorTask.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace MentorTask.Controllers;

public class HomeController : Controller
{
    private readonly MentorAppDb _context;

    public HomeController(MentorAppDb context)
    {
        _context = context;
    }

    public async Task<IActionResult>  Index()
    {
        var hero =  await _context.Heroes.FirstOrDefaultAsync();
        if (hero is null)
            return NotFound();
        HomeVm homeVm = new HomeVm
        {
            Hero = hero,
            AboutUses = await _context.AboutUses.ToListAsync(),
            Thingses = await _context.Thingses.ToListAsync()
        };
        return View(homeVm);
    }
}