using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Rating.Models.Data;
using Rating.ViewModels;

namespace Rating.Controllers
{
    public class Account : Controller
    {
        public UserManager<IdentityUser> _userManager { get; set; }
        public RoleManager<IdentityRole> _roleManager { get; set; }
        public SignInManager<IdentityUser> _signInManager { get; set; }
        public RatingContext _db { get; set; }
        public IHostEnvironment _environment { get; set; }

        public Account(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, RatingContext db, IHostEnvironment environment)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _db = db;
            _environment = environment;
        }

        // GET
          public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index","MainPage");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            
            if (ModelState.IsValid)
            {
                IdentityUser user = await _db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user != null)
                {
                   
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password,model.RememberMe,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "MainPage");
                    }

                }
                ModelState.AddModelError("","Неверная попытка входа в систему");
            }
            return View(model);
        }
        
    }
}