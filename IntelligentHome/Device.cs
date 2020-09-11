using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{

    abstract class Device : IDevice
    {

        public string Name { get; private set; }

        public bool Status { get; private set; }

        public Room Location { get; private set; }

        public Guid DeviceID { get; }

        public Device(string deviceName)
        {
            DeviceID = Guid.NewGuid();
            Name = deviceName;
        }
        public void Assign(Room room) => Location = room;

        public void TurnOnDevice()
        {
            Status = true;
            Console.WriteLine("{0} {1} is tuned on", Name, this.GetType().ToString().ToLower());
        }

        public void TurnOffDevice()
        {
            Status = false;
            Console.WriteLine("{0} {1} is tuned off", Name, this.GetType().ToString().ToLower() );
        }

        public abstract void InvokeCustomAction(string actionName);

        public void InvokeCustomAction()
        {
            throw new NotImplementedException();
        }
    }
}
