using System;
using Expotec2021.Domain.Auth;
using Expotec2021.Infra.Identity.models;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Infra.Identity.services
{
    public class SeendUserRoleInitial : ISeendUserRoleInitial
    {   
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeendUserRoleInitial(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void SeedRoles()
        {
            if (!_roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }

        public void SeedUsers()
        {
             if(_userManager.FindByEmailAsync("usuario@localhost").Result == null)
            {
                User user = new User();
                user.UserName = "usuario@localhost";
                user.Email = "usuario@localhost";
                user.NormalizedUserName = "USUARIO@LOCALHOST";
                user.NormalizedEmail = "USUARIO@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Numsey#2021").Result;

                if(result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

            if(_userManager.FindByEmailAsync("admin@localhost").Result == null)
            {
                User userAdmin = new User();
                userAdmin.UserName = "admin@localhost";
                userAdmin.Email = "admin@localhost";
                userAdmin.NormalizedUserName = "ADMIN@LOCALHOST";
                userAdmin.NormalizedEmail = "ADMIN@LOCALHOST";
                userAdmin.EmailConfirmed = true;
                userAdmin.LockoutEnabled = false;
                userAdmin.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(userAdmin, "Teste").Result;

                if(result.Succeeded)
                {
                    _userManager.AddToRoleAsync(userAdmin, "Admin").Wait();
                }
            }
        }
    }
}