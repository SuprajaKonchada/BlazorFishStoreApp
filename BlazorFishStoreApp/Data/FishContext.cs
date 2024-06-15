using BlazorFishStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorFishStoreApp.Data
{
    public class FishContext : DbContext
    {
        public FishContext(DbContextOptions<FishContext> options) : base(options) { }

        public DbSet<Fish> Fish { get; set; }
    }
}
