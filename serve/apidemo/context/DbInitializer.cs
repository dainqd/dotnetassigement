using apidemo.Entities;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace apidemo.Context;

public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }
    
    public void Seed()
    {
        modelBuilder.Entity<Users>().HasData(
            new Users(){ Id = 1, Role = Role.Admin, Username = "dainq", Password = BCrypt.Net.BCrypt.HashPassword("123456")}
        );
    }
}