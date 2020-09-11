using IntelligentHome;
using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class DoorLock : Device
    {
        private bool _doorLocked;
        public DoorLock(string doorLockName) : base(doorLockName) { }

        public void Lock()
        {
            _doorLocked = true;
            Console.WriteLine("{0} door lock is locked", Name);
        }

        public void UnLock()
        {
            _doorLocked = false;
            Console.WriteLine("{0} door lock is unlocked", Name);
        }

        public void IsLocked()
        {
            Console.WriteLine("{0} door lock is {1}", Name,  _doorLocked ? "locked" : "unlocked");
        }

        public override void InvokeCustomAction(string actionName)
        {
            throw new NotImplementedException();
        }
    }
}
