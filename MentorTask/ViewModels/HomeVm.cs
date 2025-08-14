using MentorTask.Models;

namespace MentorTask.ViewModels;

public class HomeVm
{
    public Hero Hero { get; set; }
    public List<AboutUs> AboutUses { get; set; }
    public List<Things> Thingses { get; set; }
}