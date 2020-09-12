using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface IResidentRepository<TEntity >
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        Resident GetAll(TEntity entity);

        Resident GetOne(TEntity entity);
    }
}
