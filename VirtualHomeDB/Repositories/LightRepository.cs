using System;
using System.Collections.Generic;
using System.Linq;
using VirtualHome.Models;

namespace VirtualHomeDAL.Repositories
{
    public class LightRepository : ILightRepository
    {
        private VirtualHomeDbContext dbContext;
        public LightRepository(VirtualHomeDbContext context = null)
        {
            if (context == null)
                dbContext = new VirtualHomeDbContext();
            else
                dbContext = context;
        }
        public void Add(Light entity)
        {
            dbContext.Light.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(Light entity)
        {
            dbContext.Light.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<Light> GetAll()
        {
            return dbContext.Light.ToList();
        }

        public Light GetOne(string name)
        {
            return dbContext.Light.FirstOrDefault(light => light.Name == name);
        }
    }
}
