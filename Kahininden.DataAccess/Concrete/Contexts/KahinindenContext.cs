using Kahininden.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.Contexts
{
    public class KahinindenContext : DbContext
    {
        public KahinindenContext(DbContextOptions<KahinindenContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Model oluşturma ayarlarını burada yapabilirsiniz
        }

        public DbSet<City> Citys { get; set; }
        public DbSet<EngineCapacity> EngineCapacities { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<CarProfile> CarProfiles { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
