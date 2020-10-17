using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Rating.Models.Data
{
    public class RatingContext : IdentityDbContext<IdentityUser>
    {
        
        public RatingContext(DbContextOptions<RatingContext> options) : base(options) {}
    }
}