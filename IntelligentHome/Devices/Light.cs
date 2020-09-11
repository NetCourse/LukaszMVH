using System;
using System.Collections.Generic;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.Devices
{
    class Light : Device
    {
        private string _color = "yellow";

        public Light(string deviceName) : base(deviceName)
        {
        }

        public void SetColor(string color)
        {
            _color = color;
            Console.WriteLine("Ok, {0} light on {1}", Name, color);
        }

        public override void InvokeCustomAction(string actionName)
        {
            throw new NotImplementedException();
        }
    }
}
