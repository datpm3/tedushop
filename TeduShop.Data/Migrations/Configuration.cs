namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDBContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDBContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDBContext()));

            var user = new ApplicationUser()
            {
                UserName = "tedu",
                Email = "tedu@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Truong Thanh Hai"

            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tedu@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
