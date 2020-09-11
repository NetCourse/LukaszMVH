using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    interface IDevice
    {
        Guid DeviceID { get; }

        public void Assign(Room room);

        public void TurnOn();

        public void TurnOff();

        public void InvokeCustomAction(string action);
    }
}
