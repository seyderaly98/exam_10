using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Rating.Services
{
    public class RoleInitializer
    {
        public static async Task Initialize(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            
            var roles = new[] { "Admin","User"};
            foreach (var value in roles)
            {
                string role = Convert.ToString(value);
                if (await roleManager.FindByNameAsync(role) is null)
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            string adminEmail = "admin@admin.com";
            string adminPassword = "Admin123";
            if (await userManager.FindByEmailAsync(adminEmail) is null)
            {
                IdentityUser admin = new IdentityUser
                {
                    Id = "2c4849b1-e398-44dc-a55f-11340745632e",
                    Email = adminEmail,
                    EmailConfirmed = true,
                    UserName = "Admin",
                };
                var result = await userManager.CreateAsync(admin, adminPassword);
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(admin,"Admin");
            }

        }
    }
}