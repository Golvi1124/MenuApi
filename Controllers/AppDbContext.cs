using MenuApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MenuApi.Controllers;

public class AppDbContext : DbContext
{
    public DbSet<Foods> Foods { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlite("Data Source=menu.db");
        }
    }
}
// This is the database context class that will be used to interact with the database. 
// It inherits from DbContext and has a property for each entity that will be stored in the database. 
// In this case, there is only one entity, Foods, so there is only one DbSet property.