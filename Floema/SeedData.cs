using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.Models;
using Floema.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Floema
{
    public class SeedData
    {
        public SeedData(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task Seed(IServiceProvider serviceProvider)
        {
            var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()
            );

            try
            {
                context.Database.EnsureCreated();
                if (!context.Categories.Any())
                {
                    //var baseDir = Path.Combine(WebHostEnvironment.WebRootPath, "data", "Categories.json");
                    var data = File.ReadAllText(Path.Combine(WebHostEnvironment.WebRootPath, "data", "Categories.json"));
                    var dataSeeder = JsonConvert.DeserializeObject<List<Category>>(data);

                    await context.Categories.AddRangeAsync(dataSeeder);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error Seeding", e);
            }
        }
    }
}
