using System;
using IDFOperation.HamasClasses;

namespace IDFOperation.AmanClasses
{
    // intelligance class - Intelligence Management
    public class Aman
    {
        private List<IntelligenceMessage> intelligenceMessages ;
        public Aman(List <IntelligenceMessage> IntelligenceMessages)
        {
            intelligenceMessages = IntelligenceMessages;
            private Dictionary<string, int> terroristInformation = TerroristsInformation();
        }

        //Method for adding intelligence information to a list
        public void AddIntelligance(IntelligenceMessage massage)
        {
            IntelligenceMessages.Add(massage);
        }

        //Returns a dictionary whose key is terrorist and whose value is the number of intelligence messages it has.
        static private Dictionary<string, int> TerroristsInformation()
        {
            Dictionary<string, int> terroristsInformation = new Dictionary<string, int>();
            foreach(IntelligenceMessage massege in IntelligenceMessages)
            {
                if (terroristsInformation.ContainsKey(massege.terrorist.name)
                {
                    terroristsInformation[massege.terrorist.name] = 1;
                }
                else
                {
                    terroristsInformation[massege.terrorist.name] += 1;
                }
            }
            return terroristsInformation;
        }

        //Returns the terrorist with the largest number of messages
        public string IntelligenceAnalysis()
        {
            string maxKey = 
            string dangerousTerrorist;
            return dangerousTerrorist;
        }

        //Receiving a list of terrorists returns the most dangerous terrorist
        public Terrorist MostDangoursTerrorist()
        {
            //...
            Terrorist mostDangoursTerrorist;
            return mostDangoursTerrorist;
        }

        //Receives a terrorist and returns the latest information about him
        public IntelligenceMessage TheLastIntelligance()
        {

        }

        
    }
    //Defines intelligence information
    public class IntelligenceMessage
    {
        public Terrorist terrorist { get; }
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
