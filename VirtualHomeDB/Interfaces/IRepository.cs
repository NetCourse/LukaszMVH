using System;
using System.Collections;
using System.Collections.Generic;
using VirtualHome.Models;

namespace VirtualHomeDAL
{
    interface IRepository<TEntity>
    {
        void Add(TEntity entity); 
        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetOne(string name);
    }
}
