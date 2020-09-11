using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{

    abstract class Device
    {

        public string Name { get; private set; }

        public bool IsPowered { get; private set; }

        public Room Location { get; private set; }

        public Guid DeviceID { get; }

    }
}
