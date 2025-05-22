using System;
using IDFOperation.HamasClasses;

namespace IDFOperation.AmanClasses
{
    // intelligance class - Intelligence Management
    public class Aman
    {
        private List<IntelligenceMessage> intelligenceMessages ;
        private Dictionary<string, int> terroristInformation;
        public Aman(List <IntelligenceMessage> IntelligenceMessages)
        {
            intelligenceMessages = IntelligenceMessages;
            terroristInformation = TerroristsInformation();
        }
        

        //Method for adding intelligence information to a list
        public void AddIntelligance(IntelligenceMessage massage)
        {
            intelligenceMessages.Add(massage);
        }

        //Returns a dictionary whose key is terrorist and whose value is the number of intelligence messages it has.
        private Dictionary<string, int> TerroristsInformation()
        {
            Dictionary<string, int> terroristsInformation = new Dictionary<string, int>();
            foreach(IntelligenceMessage massege in intelligenceMessages)
            {
                if (terroristsInformation.ContainsKey(massege.terrorist.name))
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
            string maxKey = "";
            int maxValue = 0;
            foreach(var mostInteligance in terroristInformation)
            {
                if (mostInteligance.Value > maxValue)
                {
                    maxValue = mostInteligance.Value;
                    maxKey = mostInteligance.Key;
                }
            }
            return maxKey;
            
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
