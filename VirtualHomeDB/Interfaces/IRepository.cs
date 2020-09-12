using System;
using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface IRepository<TEntity>
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        TEntity GetAll();

        TEntity GetOne(Guid id);
    }
}
