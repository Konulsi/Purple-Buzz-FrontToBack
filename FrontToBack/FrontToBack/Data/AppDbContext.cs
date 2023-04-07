using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SliderImage> SliderImages  { get; set; }
        public DbSet<SliderInfo> SliderInfo { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ResentWork> ResentWorks { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkImage> WorkImages { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}
