using System;
using IDFOperation.HamasClasses;

namespace IDFOperation.AmanClasses
{
    // intelligance class - Intelligence Management
    public class Aman
    {
        private List < IntelligenceMessage > IntelligenceMessages = new List < IntelligenceMessage >();

        //Method for adding intelligence information to a list
    }
    //Defines intelligence information
    public class IntelligenceMessage
    {
        private Terrorist terrorist;
        private string lastLocation;
        private string timeStemp;
        public IntelligenceMessage( Terrorist dangourTerroist, string LastLocation, string TimeStemp)
        {
            terrorist = dangourTerroist;
            lastLocation = LastLocation;
            timeStemp = TimeStemp;
        }

        
    }
}
