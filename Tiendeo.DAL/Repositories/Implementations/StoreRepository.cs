using Tiendeo.DAL.Entities;

namespace Tiendeo.DAL.Repositories
{

    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository() : base()
        {
        }
    }
}
