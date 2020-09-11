using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualHome.Devices
{

    class DeviceManager
    {
        private static DeviceManager _instance = new DeviceManager();
        //repository pattern??
        public IList<Device> deviceList = new List<Device>();
        //proteza ze tu nie ma bazy

        private DeviceManager()
        {
            Console.WriteLine("Device Manager Created");
        }
        //singleton
        public static DeviceManager CreateInstance => _instance;

        public void AssignDevice(Room room, Device device) 
        {
            deviceList.Add(device);
            device.Assign(room); 
        }

        //add exception handling
        public void RemoveDevice(Device device)
        {
            if (deviceList.Where(registerDevice => registerDevice == device).Count() == 0)
                Console.WriteLine($"{device.Name}, {device.GetType()} not found");
            deviceList.Remove(device);
            Console.WriteLine("{0} {1} removed",device.DeviceID ,device.GetType().ToString().ToLower());
        }
        
        public T GetDevice<T>(string deviceName) where T : Device
        {
            var devices = deviceList.Where(device => device.Name.Equals(deviceName));
            if (devices.Count() > 1)
            {
                // Handle error
                Console.WriteLine("Multiply devices found. Only first return. Please try specify the room");
            }
            return devices.FirstOrDefault() as T;
        }

        public T GetDevice<T>(string deviceName, string roomName) where T : Device
        {
            var devices = deviceList.Where(device => device.Name.Equals(deviceName) && device.Location.Name == roomName);
            if (devices.Count() > 1)
            {
                // Handle error
                Console.WriteLine($"In {roomName} multiply devices found. Cannot handle.");
            }
            return devices.FirstOrDefault() as T;
        }
    }
}
