using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rating.Models;
using Rating.Models.Data;

namespace Rating.Controllers
{
    public class MainPageController : Controller
    {
        public UserManager<IdentityUser> _userManager { get; set; }
        public RoleManager<IdentityRole> _roleManager { get; set; }
        public RatingContext _db { get; set; }

        public MainPageController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, RatingContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            List<Institution> institutions = await _db.Institutions.ToListAsync();
            return View(institutions);
        }
    }
}