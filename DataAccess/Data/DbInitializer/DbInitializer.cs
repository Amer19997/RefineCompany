﻿
using DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RefineModels.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.DbInitializer {
    public class DbInitializer : IDbInitializer {

 		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db) {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }


        public void Initialize() {


            //migrations if they are not applied
            try {
                if (_db.Database.GetPendingMigrations().Count() > 0) {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex) { }

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@dotnetmastery.com",
                Email = "admin@dotnetmastery.com",
                 PhoneNumber = "1112223333",
               
            }, "Admin123*").GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "Hanan",
                Email = "admin@dotnetmasteries.com",
                PhoneNumber = "343",

            }, "Admin123*").GetAwaiter().GetResult();
            //create roles if they are not created


            return;
        }
    }
}
