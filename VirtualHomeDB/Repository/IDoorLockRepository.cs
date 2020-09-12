using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface IDoorLockRepository<TEntity >
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        DoorLock GetAll(TEntity entity);

        DoorLock GetOne(TEntity entity);
    }
}
