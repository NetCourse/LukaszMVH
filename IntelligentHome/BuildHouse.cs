using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.BLL
{
    static class BuildHouse
    {
        public static List<Room> BuildHome()
        {
            var home = new List<Room>();

            home.Add(new Room("Kitchen", Rooms.Kitchen));
            home.Add(new Room("Hallway", Rooms.Hallway));
            home.Add(new Room("Bathroom", Rooms.Bathroom));
            home.Add(new Room("Toilet", Rooms.Bathroom));
            home.Add(new Room("Living Room", Rooms.LivingRoom));
            home.Add(new Room("Bedroom", Rooms.Bedroom));

            return home;
        }

        public static void EquipAllRooms(List<Room> home, string deviceType)
        {
            DeviceManager deviceManager = DeviceManager.CreateInstance;
            foreach (Room room in home)
            {
                switch (deviceType.ToLower()) 
            {
                case "tv": { deviceManager.AssignDevice(room, new TV($"{room.Name} tv")); break; }
                case "light": { deviceManager.AssignDevice(room, new Light($"{room.Name} light")); break; }
                case "doorlock": { deviceManager.AssignDevice(room, new DoorLock($"{room.Name} doorlock")); break; }
                default:    throw new ArgumentException($"{deviceType} type not recognized");
            }
            
                
            }
        }

    }
}
