using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using RefineModels.Models.ANRPC;
using RefineModels.Models.Identity;

namespace Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            if (!context.AnrpcTable1.Any())
            {
                var Anrpc1Data = File.ReadAllText("../DataAccess/Data/SeedData/Anrpc1.json");
                var Anrpc1 = JsonSerializer.Deserialize<List<AnrpcTable1>>(Anrpc1Data);
                context.AnrpcTable1.AddRange(Anrpc1);
                if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();


                context.SaveChanges();
            }

            if (!context.AnrpcTable2.Any())
            {
                var Anrpc2Data = File.ReadAllText("../DataAccess/Data/SeedData/Anrpc2.json");
                var Anrpc2 = JsonSerializer.Deserialize<List<AnrpcTable2>>(Anrpc2Data);
                context.AnrpcTable2.AddRange(Anrpc2);
                if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();


                context.SaveChanges();
            }
            //if (!userManager.Users.Any())
            //{
            //    var user = new ApplicationUser
            //    {
            //        DisplayName = "Bob",
            //        Email = "bob@test.com",
            //        UserName = "bob@test.com",
            //        Address = new Address
            //        {
            //            FirstName = "Bob",
            //            LastName = "Bobbity",
            //            Street = "10 The street",
            //            City = "New York",
            //            State = "NY",
            //            Zipcode = "90210"
            //        }
            //    };

            //    await userManager.CreateAsync(user, "Pa$$w0rd");


            //if (!context.productsBrands.Any())
            //{
            //    var productsBrandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
            //    var brands = JsonSerializer.Deserialize<List<ProductsBrands>>(productsBrandsData);
            //    context.productsBrands.AddRange(brands);
            //}
            //if (!context.productTypes.Any())
            //{
            //    var productsTypesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
            //    var types = JsonSerializer.Deserialize<List<ProductType>>(productsTypesData);
            //    context.productTypes.AddRange(types);
            //}
        }
        }
    }
