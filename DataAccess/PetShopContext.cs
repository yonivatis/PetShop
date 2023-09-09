using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShopProject.Models;

namespace PetShopProject.Data
{
    public class PetShopContext : IdentityDbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options)
        {
        }
        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
