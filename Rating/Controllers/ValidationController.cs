using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rating.Models.Data;

namespace Rating.Controllers
{
    public class ValidationController : Controller
    { private RatingContext _db;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public ValidationController(RatingContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET
        public async Task<bool> CheckEmail(string email)
        {
            return !await _db.Users.AnyAsync(u => u.Email == email);
        }
       
    }
}