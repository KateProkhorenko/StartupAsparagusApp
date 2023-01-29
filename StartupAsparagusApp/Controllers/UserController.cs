using Microsoft.AspNetCore.Mvc;
using StartupAsparagusApp.Data;
using StartupAsparagusApp.Interfaces;
using StartupAsparagusApp.Models;
using System.Linq;


namespace StartupAsparagusApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;
        public UserController(IUserRepository Urepository) 
        { 
            repository = Urepository;
        }
        public IActionResult Index()
        { 
           return View(repository.GetUsers()); 
        }

        public IActionResult SubmitAsparagus()
        {
            return View("SubmitAsparagus", new User());
        }
        [HttpPost]
        public async Task<IActionResult> SubmitAsparagus([FromForm] User user)
        {
            if (ModelState.IsValid)
            {
                User? u = repository.GetUsers().FirstOrDefault(u => u.Email == user.Email);
                if (u == null)
                {
                    user.UserId = repository.GetUsers().Max(u => u.UserId + 1);
                    user.NumberOfMeals = 1;
                }
                else
                {
                    user.UserId = repository.GetUsers().First(u => u.Email == user.Email).UserId;
                    user.NumberOfMeals = repository.GetUsers()
                        .Where(u => u.UserId == user.UserId).Max(u => u.NumberOfMeals + 1);


                }

                user.DateEating = DateTime.Now;
                user.Comment = $"{user.Name} has already eaten asparagus {user.NumberOfMeals} times";
                await repository.SaveAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View("SubmitAsparagus", user);

        }
    }
}
