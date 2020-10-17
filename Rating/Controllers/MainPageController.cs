using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rating.Models;
using Rating.Models.Data;
using Rating.Services;

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
        public async Task<IActionResult> Index(int page = 1)
        { 
            int pageSize = 5;
            IEnumerable<Institution> institutions = _db.Institutions.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = _db.Institutions.Count()};
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Institutions = institutions };
            return View(ivm);
        }
    }
}