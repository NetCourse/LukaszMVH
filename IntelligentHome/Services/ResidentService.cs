using System;
using System.Collections.Generic;
using System.Text;
using VirtualHome.Devices;
using VirtualHomeDAL.Repositories;

namespace VirtualHome.BLL
{
    class ResidentService
    {
        DeviceService deviceService = DeviceService.CreateInstance;
        private ResidentRepository residentService = new ResidentRepository();

        private ResidentService()
        {
            Console.WriteLine("ResidentObserver initialized");
        }

        public void OnEnterHome(object source, EventArgs e)
        {
            
        }
    }
}
