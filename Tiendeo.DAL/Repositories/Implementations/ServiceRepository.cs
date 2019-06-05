using Tiendeo.DAL.Entities;

namespace Tiendeo.DAL.Repositories
{

    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository() : base()
        {
        }
    }
}
