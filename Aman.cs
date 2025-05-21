using System;

namespace IDFOperation.AmanClasses
{
    // intelligance class - Intelligence Management
    public class Aman
    {
        List < IntelligenceMessage > IntelligenceMessages = new List < IntelligenceMessage >();

        //Method for adding intelligence information to a list
    }
    //Defines intelligence information
    public class IntelligenceMessage
    {
        private string terrorist;
        private string lastLocation;
        private string timeStemp;
        //It requires defining a special class for the terrorist and changing the input.
        public IntelligenceMessage(string Terrorist, string LastLocation, string TimeStemp)
        {
            terrorist = Terrorist;
            lastLocation = LastLocation;
            timeStemp = TimeStemp;
        }

        
    }
}
