﻿using System;

namespace VirtualHome.Models
{
    public class DoorLock
    { 
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsPowered { get; set; }

        public bool Lock { get; set; }

        public virtual Room Location { get; set; }

        public string Color { get; set; }
    }
}

