using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface ILightRepository<TEntity >
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        Light GetAll(TEntity entity);

        Light GetOne(TEntity entity);
    }
}
