using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualHome;
using VirtualHome.BLL;
using VirtualHomeDAL.Repositories;

namespace IntelligentHome
{

    class Resident
    {
        //Create event
        //1+2. Define delegate and event based on delegate
        public event EventHandler<EventArgs> HomeEntered;
        
        protected virtual void OnEnterHome(EventArgs e)
        {
            if (HomeEntered != null)
                HomeEntered(this, EventArgs.Empty);   
        }
        public string Name { get; }
        public Room Localization { get; private set; }

        public Resident(string residentName)
        {
            Name = residentName;
        }

        public void EnterHome(List<Room> home) 
        {
            var enumName = Rooms.Hallway.ToString();
            Localization = home.FirstOrDefault(room => enumName == room.Name);
        }


    }
}
