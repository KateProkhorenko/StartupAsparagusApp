using StartupAsparagusApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using StartupAsparagusApp.Interfaces;
using StartupAsparagusApp.Repository;

namespace StartupAsparagusApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<UserDataContext>(opts => 
            {
                opts.UseSqlServer(builder.Configuration["ConnectionStrings:UsersConnection"]);
            });
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUserRepository,UserRepository>();

            var app = builder.Build();
                        
            app.UseStaticFiles();
            app.MapControllers();
            app.MapControllerRoute("Default", "/{controller=User}/{action=SubmitAsparagus}");
            

            var context = app.Services.CreateScope().ServiceProvider
                            .GetRequiredService<UserDataContext>();
            SeedData.SeedDatabase(context);
           
            app.Run();
        }
    }
}