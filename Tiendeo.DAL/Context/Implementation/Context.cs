using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tiendeo.DAL.Entities;

namespace Tiendeo.DAL
{
    public class Context : DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<City> City { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Enterprise> Enterprise { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
