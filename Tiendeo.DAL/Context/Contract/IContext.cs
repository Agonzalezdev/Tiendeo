using Microsoft.EntityFrameworkCore;
using Tiendeo.DAL.Entities;

namespace Tiendeo.DAL
{
    public interface IContext
    {
        int SaveChanges();

        void Dispose();

        DbSet<T> Set<T>() where T : class;

        DbSet<City> City { get; set; }
        DbSet<Establishment> Establishment { get; set; }
        DbSet<Province> Province { get; set; }
        DbSet<Service> Service { get; set; }
        DbSet<Store> Store { get; set; }
        DbSet<Enterprise> Enterprise { get; set; }
    }
}
