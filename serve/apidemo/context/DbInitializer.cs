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
            new Users()
            {
                Id = 1, Role = Role.Admin, Username = "dainq",Email = "admin@gmail.com",
                FirstName = "ADmin", LastName = "World",
                Password = BCrypt.Net.BCrypt.HashPassword("123456")
            },
             new Users(){ Id = 2, Role = Role.User, Username = "user", Email = "user@gmail.com",
                 FirstName = "HEllo", LastName = "World",
                Password = BCrypt.Net.BCrypt.HashPassword("123456")},
        new Subject()
        {
            Id = 1, Status = SubjectStatus.ACTIVE, StartTime = "10:10", Date = "20-02-2022", Duration = 10,
            ClassRoom = "B16", Faculty = "IT", Name = "JAVA"
        },
        new Subject(){ Id = 2, Status = SubjectStatus.ACTIVE, StartTime = "10:10", Date = "10-02-2022", Duration = 20,
            ClassRoom = "B10", Faculty = "IT", Name = "NET Core"},
            new Subject(){ Id = 3, Status = SubjectStatus.ACTIVE, StartTime = "10:10", Date = "10-10-2022", Duration = 40,
                ClassRoom = "B6", Faculty = "IT Support", Name = "PHP"}
        );
    }
}