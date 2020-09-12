using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface ITVRepository<TEntity >
    {
        void AddTV(TEntity entity); 
        void DeleteTV(TEntity entity);

        TV GetAll(TEntity entity);

        TV GetOne(TEntity entity);
    }
}
