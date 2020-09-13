using System.Collections.Generic;
using System.Linq;
using VirtualHome.Models;

namespace VirtualHomeDAL.Repositories
{
    public class DoorLockRepository : IDoorLockRepository
    {
        private VirtualHomeDbContext dbContext;
        public DoorLockRepository(VirtualHomeDbContext context=null) {
            if (context == null) 
                dbContext = new VirtualHomeDbContext();
            else
                dbContext = context;
        } 
        public void Add(DoorLock entity)
        {
            dbContext.DoorLock.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(DoorLock entity)
        {
            dbContext.DoorLock.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<DoorLock> GetAll()
        {
            return dbContext.DoorLock.ToList();
        }

        public DoorLock GetOne(string name)
        {
            return dbContext.DoorLock.FirstOrDefault(doorlock => doorlock.Name == name);
        }

    }
}
