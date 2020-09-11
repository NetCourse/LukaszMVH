using System;
using System.Collections.Generic;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.Devices
{
    class Light : Device
    {
        public string Color { get; private set; }

        public Light(string deviceName) : base(deviceName)
        {
            Color = "yellow";
        }

        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine("Ok, {0} light on {1}", Name, color);
        }

        public override void InvokeCustomAction(string actionName)
        {
            throw new NotImplementedException();
        }
    }
}
