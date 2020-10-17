using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Rating.Models;
using Rating.Models.Data;
using Rating.Services;

namespace Rating.Controllers
{
    public class InstitutionsController : Controller
    {
        public UserManager<IdentityUser> _userManager { get; set; }
        public RoleManager<IdentityRole> _roleManager { get; set; }
        public RatingContext _db { get; set; }
        public IHostEnvironment _environment { get; set; }
        private CreateFile _createFile { get; set; }

        public InstitutionsController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, RatingContext db, IHostEnvironment environment, CreateFile createFile)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _environment = environment;
            _createFile = createFile;
        }

        // GET
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(Institution model)
        {
            if (ModelState.IsValid)
            {
                if (model.File != null)
                {
                    string directoryPath = Path.Combine(_environment.ContentRootPath,$"wwwroot/images/Institution/{model.Name}");
                    if (!Directory.Exists(directoryPath))
                        Directory.CreateDirectory(directoryPath);
                    await _createFile.Create(directoryPath,model.File.FileName,model.File);
                    model.PhotoPath= $"images/Institution/{model.Name}/{model.File.FileName}";
                }

                var user = await _db.User.FirstOrDefaultAsync(u => u.Id == _userManager.GetUserId(User));
                model.Author = user.UserName;
                model.UserId = user.Id;
                await _db.Institutions.AddAsync(model);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "MainPage");
            }
            return View(model);
        }
        
        public async Task<IActionResult> Details(int? institutionId)
        {
            if (institutionId != null)
            {
                Institution institution = await _db.Institutions.FirstOrDefaultAsync(i => i.Id == institutionId);
                if (institution != null)
                {
                    institution.Gallery = _db.Gallery.Where(g => g.InstitutionId == institution.Id).ToList();
                    return View(institution);
                }
            }
            return NotFound();
        }
    }
}