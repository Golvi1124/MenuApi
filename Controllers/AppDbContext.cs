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




/* 
Since you're using dependency injection (DI) in ASP.NET Core, modify AppDbContext.cs to use dependency injection-friendly configuration.

using System;
using MenuApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MenuApi.Controllers;

public class AppDbContext : DbContext
{
    public DbSet<Foods> Foods { get; set; }
     public DbSet<Households> Households { get; set; } ...will take care of Foods first

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=menu.db");
  will this change something??  
 
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // what was this one doing?
    {
    } 
}
 */