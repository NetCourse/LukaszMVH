using System;
using System.Collections.Generic;

namespace VirtualHome.Models
{
    public class TV

    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsPowered { get; set; }

        public virtual Room Location { get; set; }

        private int CurrentChannel { get; set; }
        
    }
}
