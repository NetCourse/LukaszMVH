using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome;

namespace IntelligentHome
{

    class Resident
    {
        //Create event
        //1+2. Define delegate and event based on delegate
        public event EventHandler<EventArgs> EnterHome;
        public event EventHandler<EventArgs> ChangeRoom;
        //3. Raise event
        protected virtual void OnEnterHome(EventArgs e)
        {
            if (EnterHome != null)
                EnterHome(this, EventArgs.Empty);   
        }
        public string Name { get; }
        public Room Localization { get; private set; }

        public Resident(string residentName)
        {
            Name = residentName;
        }

        public void enterHome(List<Room> home) 
        {
            var enumName = Rooms.Hallway.ToString();
            Localization = home.FirstOrDefault(room => enumName == room.Name);
        }


    }
}
