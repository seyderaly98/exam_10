using System;
using System.Collections.Generic;
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
        
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            List<Institution> list = new List<Institution>();
            for (int i = 1; i < 30; i++)
            {
                list.Add(
                        new Institution
                        {
                            Name = "BurgerKing",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                            Rating = 4, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e", Id = i,PhotoCount = 9
                        }
                    );
            }
            

            base.OnModelCreating(builder);
            builder.Entity<Institution>().HasData(list);

            List<GalleryInstitution> gallery = new List<GalleryInstitution>();
            for (int k = 1; k < 6; k++)
            {
                for (int i = 1; i < 30; i++)
                {
                   gallery.Add(new GalleryInstitution {InstitutionId = i,Id = Guid.NewGuid().ToString(),Author = "Admin",PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e"});
                }
            }
            
            base.OnModelCreating(builder);
            builder.Entity<GalleryInstitution>().HasData(gallery);
        }
    }
}