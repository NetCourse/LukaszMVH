using System;

namespace VirtualHome.Models
{

    public class Resident
    {
 
        public Guid  ResidentId { get; set; }
        public string Name { get; set; }
        public Room Localization { get; set; }

    }
}
