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
            base.OnModelCreating(builder);
            builder.Entity<Institution>().HasData(
                new Institution[]
                {
                    new Institution
                    {
                        Name = "BurgerKing",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 5, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e", Id = 1
                    },
                    new Institution
                    {
                        Name = "Burger1",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 2, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 2
                    },
                    new Institution
                    {
                        Name = "Burger2",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 1, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 3
                    },
                    new Institution
                    {
                        Name = "Burger3",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 4, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 4
                    },
                    new Institution
                    {
                        Name = "Burger4",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 2, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 5
                    },
                    new Institution
                    {
                        Name = "Burger5",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 3, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 6
                    },
                    new Institution
                    {
                        Name = "Burger6",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 4, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 7
                    },
                    new Institution
                    {
                        Name = "Burger7",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 4, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 8
                    },
                    new Institution
                    {
                        Name = "Burger8",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 2, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 9
                    },
                    new Institution
                    {
                        Name = "Burger9",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 3, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 10
                    },
                    new Institution
                    {
                        Name = "Burger10",Description = "Приложение должно запуститься на компьютере проверяющего без дополнительной настройки компьютера (сверх той, что описана в README.md) и любого другого участия проверяющего (например, исправление багов и создание фикстур самостоятельно) направленного на починку программы;",
                        Rating = 5, Author = "Admin", PhotoPath = "images/etc/def.jpg", UserId = "2c4849b1-e398-44dc-a55f-11340745632e",Id = 11
                    }
                });
        }
    }
}