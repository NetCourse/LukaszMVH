using System;
using System.Collections.Generic;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.Devices
{
    class Light : Device
    {
        public string Color { get; private set; }
    }
}
