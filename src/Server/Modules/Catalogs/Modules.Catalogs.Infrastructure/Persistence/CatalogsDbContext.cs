using Microsoft.EntityFrameworkCore;
using Modules.Catalogs.Core.Entites;

namespace Modules.Catalogs.Infrastructure.Persistence
{
    public class CatalogsDbContext : DbContext
    {
        public CatalogsDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
