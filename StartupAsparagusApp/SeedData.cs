using Microsoft.EntityFrameworkCore;
using StartupAsparagusApp.Data;
using StartupAsparagusApp.Models;

namespace StartupAsparagusApp
{
    public static class SeedData
    {
        public static void SeedDatabase(UserDataContext context)
        { 
            context.Database.Migrate();
            if (context.Users.Count() == 0)
            {
                context.Users.AddRange(
                    new User
                    {
                        UserId = 1,
                        Name = "Bob",
                        Email = "bob@gmail.com",
                        NumberOfMeals = 10,
                        Comment = $"Bob has already eaten asparagus 10 times",
                        DateEating = DateTime.Now
                        
            },
                    new User
                    {
                        UserId = 2,
                        Name = "Max",
                        Email = "max@gmail.com",
                        NumberOfMeals = 8,
                        Comment = $"Max has already eaten asparagus 8 times",
                        DateEating = DateTime.Now
                        
                    },
                    new User
                    {
                        UserId = 3,
                        Name = "John",
                        Email = "john@gmail.com",
                        NumberOfMeals = 5,
                        Comment = $"John has already eaten asparagus 5 times",
                        DateEating = DateTime.Now
                        
                    },
                    new User
                    {
                        UserId = 4,
                        Name = "Alice",
                        Email = "alice@gmail.com",
                        NumberOfMeals = 7,
                        Comment = $"Alice has already eaten asparagus 7 times",
                        DateEating = DateTime.Now
                        
                    },
                    new User
                    {
                        UserId = 5,
                        Name = "Tom",
                        Email = "tom@gmail.com",
                        NumberOfMeals = 3,
                        Comment = $"Tom has already eaten asparagus 3 times",
                        DateEating = DateTime.Now
                        
                    });
                context.SaveChanges();
            }
        }

    }
}
