using AutoMapper;
using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHomeDAL.Repositories;

namespace VirtualHome.Devices
{

    class DeviceService
    {
        private static DeviceService _instance = new DeviceService();
        //proteza ze tu nie ma bazy... poki co
        public IList<Device> deviceList = new List<Device>();
        private TVRepository tvRepository = new TVRepository();
        private LightRepository lightRepository = new LightRepository();
        private DoorLockRepository doorLockRepository = new DoorLockRepository();
        private RoomRepository roomRepository = new RoomRepository();

        private DeviceService()
        {
            Console.WriteLine("Device Manager Created");
        }
        //singleton
        public static DeviceService CreateInstance => _instance;

        public void AssignDevice(Room room, Device device) 
        {
            var mapper = new Mapper();
            var deviceType = device.GetType().ToString();
            switch (deviceType)
            {
                case "TV":
                    tvRepository.Add( device);
                    break;
                case "Light":

                    break;
                default: 
                    Console.WriteLine($"Not recognized device type, {deviceType}"); 
                    break;
            }
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
        private T GetOne<T> (string name) where T : Device
            {
            
            return null;
            }
        

    }
}
