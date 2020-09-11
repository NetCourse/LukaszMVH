using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.BLL
{
    class HouseBuilder
    {
        private List<Room> _home;

        public HouseBuilder()
        {
            _home = new List<Room>();
        }

        public HouseBuilder AddRooms()
        {
            _home.Add(new Room("Kitchen", Rooms.Kitchen));
            _home.Add(new Room("Hallway", Rooms.Hallway));
            _home.Add(new Room("Bathroom", Rooms.Bathroom));
            _home.Add(new Room("Toilet", Rooms.Bathroom));
            _home.Add(new Room("Living Room", Rooms.LivingRoom));
            _home.Add(new Room("Bedroom", Rooms.Bedroom));

            return this;
        }

        public HouseBuilder EquipAllRooms(string deviceType)
        {
            DeviceManager deviceManager = DeviceManager.CreateInstance;
            foreach (Room room in _home)
            {
                switch (deviceType.ToLower())
                {
                    case "tv": { deviceManager.AssignDevice(room, new TV($"{room.Name} tv")); break; }
                    case "light": { deviceManager.AssignDevice(room, new Light($"{room.Name} light")); break; }
                    case "doorlock": { deviceManager.AssignDevice(room, new DoorLock($"{room.Name} doorlock")); break; }
                    default: throw new ArgumentException($"{deviceType} type not recognized");
                }
            }

            return this;
        }

        public List<Room> Build()
        {
            return _home;
        }
    }
}
