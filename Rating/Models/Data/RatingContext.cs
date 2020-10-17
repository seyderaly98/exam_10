using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Rating.Models.Data
{
    public class RatingContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<IdentityUser> User { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<GalleryInstitution> Gallery { get; set; }
        public RatingContext(DbContextOptions<RatingContext> options) : base(options) {}
    }
}