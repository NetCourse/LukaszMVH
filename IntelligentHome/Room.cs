using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome;
using VirtualHome.Devices;

namespace IntelligentHome
{
    class Room
    {
        public string Name { get; }
        static DeviceService deviceManager = DeviceService.CreateInstance;
        public Rooms Type { get; }

        public Room(string name, Rooms type)
        {
            Type = type;
            Name = name;
        }

        public IEnumerable<Device> Devices()
        {
            //ogarnąc xunit
            //zwróc wyrażenie. Jesli puste to zwróc pustą kolekcje
            var temp = deviceManager.deviceList.Where(device => device.Location == this);
            return temp;
        }

        public void RemoveDevice(Device device)
        {
            //assignDevices(device) != null ? assignDevices.Remove(device);
        }



    }
}
