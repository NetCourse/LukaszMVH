using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome.Models;

namespace VirtualHomeDAL.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private VirtualHomeDbContext dbContext;
        public RoomRepository(VirtualHomeDbContext context = null)
        {
            if (context == null)
                dbContext = new VirtualHomeDbContext();
            else
                dbContext = context;
        }
        public void Add(Room entity)
        {
            dbContext.Room.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(Room entity)
        {
            dbContext.Room.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<Room> GetAll()
        {
            return dbContext.Room.ToList();
        }

        public Room GetOne(string name)
        {
            return dbContext.Room.FirstOrDefault(room => room.Name == name);
        }
    }
}
