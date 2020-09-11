using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHomeDAL
{
    interface IRepository<TEntity >
    {
        void Add(TEntity entity);
    }
}
