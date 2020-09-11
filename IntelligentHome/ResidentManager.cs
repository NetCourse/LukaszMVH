using System;
using System.Collections.Generic;
using System.Text;
using VirtualHome.Devices;

namespace VirtualHome.BLL
{
    class ResidentManager
    {
        DeviceManager deviceManager = DeviceManager.CreateInstance;

        private ResidentManager()
        {
            Console.WriteLine("ResidentObserver initialized");
        }

        public void OnEnterHome(object source, EventArgs e)
        {
            
        }
    }
}
