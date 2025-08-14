using MentorTask.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorTask.Data;

public class MentorAppDb:DbContext
{
public MentorAppDb(DbContextOptions<MentorAppDb> options) : base(options)
{
}

public DbSet<Hero> Heroes { get; set; }
public DbSet<AboutUs> AboutUses { get; set; }
public DbSet<Things> Thingses { get; set; }
}