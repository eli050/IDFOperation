using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.AmanClasses
{
    public class Aman
    {
        List < IntelligenceMessage > IntelligenceMessages = new List < IntelligenceMessage >();
    }
    public class IntelligenceMessage
    {
        private string terrist;
        private string lastLocation;
        private string timeStemp;
        //It requires defining a special class for the terrorist and changing the input.
        public IntelligenceMessage(string Terrorist, string LastLocation, string TimeStemp)
        {
            terrist = Terrorist;
            lastLocation = LastLocation;
            timeStemp = TimeStemp;
        }
    }
}
