using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    public class UserDataInitializer : IdataInitializer
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;

        public UserDataInitializer(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public void InitializeData()
        {
            if (!roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                roleManager.CreateAsync(new Role { Name = "Admin", Description = "Admin role" }).GetAwaiter().GetResult();
            }
            if (!userManager.Users.AsNoTracking().Any(p => p.UserName == "Admin"))
            {

                var user = new User
                {
                    BirthDate = DateTime.Now.AddYears(-25),
                    FirstName = "سید مهدی",
                    LastName = "معصومی",
                    Gender = GenderType.Male,
                    UserName = "admin",
                    Email = "admin@site.com",
                    Education="Edu",
                    Mobile="09368915297",
                    
                    CompanyId=1
                };
                userManager.CreateAsync(user, "123456").GetAwaiter().GetResult();
                userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
            }
        }
    }
}