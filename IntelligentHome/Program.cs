using System;
using System.Collections.Generic;
using System.Linq;
using VirtualHome;
using VirtualHome.BLL;
using VirtualHome.Devices;

namespace IntelligentHome
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create Residents
            Resident Janusz = new Resident("Janusz");

            //Init DeviceManager
            DeviceManager deviceManager = DeviceManager.CreateInstance;

        //Define delegates(actions) as routines
        Action<string> lightColorDefaultSetting = Console.WriteLine;
            //Build a house
            var home = BuildHouse.BuildHome();

            //Equip all rooms
            BuildHouse.EquipAllRooms(home,"light");
            BuildHouse.EquipAllRooms(home,"doorlock");

            //Add Custom devices
            deviceManager.AssignDevice(home.FirstOrDefault(room => room.Name == "Bathroom"), new TV("SonyBravia2"));
            deviceManager.AssignDevice(home.FirstOrDefault(room => room.Name == "Kitchen"), new TV("SonyBravia"));
            deviceManager.AssignDevice(home.FirstOrDefault(room => room.Name == "Kitchen"), new DoorLock("Backdoor"));
            //deviceManager.RemoveDevice(deviceManager.GetDevice<DoorLock>("Backdoor"));
            Console.WriteLine("Kitchen device list:");
            //display devices for room by name
            IEnumerable<Device> kitchenDevices = home.FirstOrDefault(room => room.Name == "Kitchen").Devices();
            foreach (Device device in kitchenDevices)
            {
                Console.WriteLine("- " + device.Name);
            }

            Console.WriteLine("Batchroom rooms device list:");
            //display devicess for room by type
            var deviceList = home.Where(room => room.Type == Rooms.Bathroom).Select(room => room.Devices());
            foreach (IEnumerable<Device> room in deviceList)
            {
                foreach (Device device in room)
                {
                    Console.WriteLine("- " + device.Name);
                }
            }

            Console.WriteLine("All register devices:");
            //display devices by type
            foreach (Device device in deviceManager.deviceList.OrderBy(device => device.Location.Name))
            {
                Console.WriteLine($"- {device.Name} in {device.Location.Name}");
            }

            foreach(Light device in deviceManager.deviceList.Where(device => device is Light))
            {
                turnOnAllLight += device.TurnOnDevice;
                lightColorDefaultSetting += device.SetColor;
            }
                
            //invoke 
            turnOnAllLight();
            lightColorDefaultSetting("yellow");

            // bll => console app day 1 (patterns (singleton (device manager), ?factory? (device factory) ), DI (deviceManager => Rooms)
            // +
            // action and func => delegat
            // +
            // event => observer pattern
            // entity framework => repository pattern
            // unit test => n/unit xunit
            // make as API => .Net Core MVC API
        }
    }
}
