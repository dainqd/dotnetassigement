using apidemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace apidemo.Context;

public class MySQLDBContext : DbContext
{
    //public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DbSet<Users> Users { get; set; }
    
    public DbSet<Subject> Subject { get; set; }
    
    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }
}