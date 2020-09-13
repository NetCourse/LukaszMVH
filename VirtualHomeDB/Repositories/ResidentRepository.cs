using System.Collections.Generic;
using System.Linq;
using VirtualHome.Models;

namespace VirtualHomeDAL.Repositories
{
    public class ResidentRepository : IResidentRepository
    {
        private VirtualHomeDbContext dbContext;
        public ResidentRepository(VirtualHomeDbContext context = null)
        {
            if (context == null)
                dbContext = new VirtualHomeDbContext();
            else
                dbContext = context;
        }
        public void Add(Resident entity)
        {
            dbContext.Resident.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(Resident entity)
        {
            dbContext.Resident.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<Resident> GetAll()
        {
            return dbContext.Resident.ToList();
        }

        public Resident GetOne(string name)
        {
            return dbContext.Resident.FirstOrDefault(resident => resident.Name == name);
        }
    }
}
