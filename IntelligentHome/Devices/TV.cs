using System;
using System.Collections.Generic;

namespace VirtualHome
{
    class TV : Device

    {
        private int _currentChannel;
        
        private static List<string> _channelList = new List<string> { "TVN", "Polsat", "Super Stacja", "TVP1", "Trwam"};

        public TV(string deviceName) : base(deviceName) 
        {
            Console.WriteLine("In house appeared {0} tv", Name);
        }
        // add more detailed logic plus exception handling
        public void ChangeChannel()
        {
            Random newChannelIndex = new Random();
            _currentChannel = newChannelIndex.Next(_channelList.Count);
            Console.WriteLine("In {1} tv is {0}", _channelList[_currentChannel], Name);
        }

        public override void InvokeCustomAction(string actionName)
        {
            throw new NotImplementedException();
        }
    }
}
