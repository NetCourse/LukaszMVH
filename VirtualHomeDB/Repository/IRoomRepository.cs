using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHomeDAL
{
    interface IRepository<TEntity >
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        //<TEntity> GetAll(TEntity entity);

        //<TEntity> GetOne(Tentity entity);
    }
}
