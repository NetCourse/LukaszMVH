using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome;

namespace IntelligentHome
{
    //Create event
    //1. Define delegate
    public delegate void EnterHomeEventHandler(object source, EventArgs args);
    //2. Define event based on delegate
    public event EnterHomeEventHandler EnterHome;
    //3. Raise event

    class Resident
    {
        public string Name { get; }
        public Room Localization { get; private set; }

        public Resident(string residentName)
        {
            Name = residentName;
        }

        public void enterHome(List<Room> home) 
        {
            Localization = home.Where(room => Rooms.Hallway.Equals(room.Name));
        }


    }
}
