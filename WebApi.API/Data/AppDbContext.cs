using Microsoft.EntityFrameworkCore;
using WebApi.API.Models.Domain;

namespace WebApi.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk>  Walks { get; set; }
    }
}
