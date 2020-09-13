using System.Collections.Generic;
using System.Linq;
using VirtualHome.Models;

namespace VirtualHomeDAL.Repositories
{
    public class TVRepository : ITVRepository
    {
        private VirtualHomeDbContext dbContext;
        public TVRepository(VirtualHomeDbContext context = null)
        {
            if (context == null)
                dbContext = new VirtualHomeDbContext();
            else
                dbContext = context;
        }
        public void Add(TV entity)
        {
            dbContext.TV.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(TV entity)
        {
            dbContext.TV.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<TV> GetAll()
        {
            return dbContext.TV.ToList();
        }

        public TV GetOne(string name)
        {
            return dbContext.TV.FirstOrDefault(tv => tv.Name == name);
        }
    }
}
