using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ArgentumSite.Models;

namespace ArgentumSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GoodCard> GoodCards { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {             
        }


    }
}