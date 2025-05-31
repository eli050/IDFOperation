using System;
using System.Security.Cryptography.X509Certificates;
using IDFOperation.HamasClasses;

namespace IDFOperation.AmanClasses
{
    // intelligance class - Intelligence Management
    public class Aman
    {
        public List<IntelligenceMessage> intelligenceMessages ;
        private Dictionary<Terrorist, int> terroristInformation;
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
        private Dictionary<Terrorist, int> TerroristsInformation()
        {
            Dictionary<Terrorist, int> terroristsInformation = new Dictionary<Terrorist, int>();
            foreach(IntelligenceMessage massege in intelligenceMessages)
            {
                if (terroristsInformation.ContainsKey(massege.terrorist))
                {
                    terroristsInformation[massege.terrorist] += 1;
                }
                else
                {
                    terroristsInformation[massege.terrorist] = 1;
                }
            }
            return terroristsInformation;
        }

        //Returns the terrorist with the largest number of messages
        public Terrorist IntelligenceAnalysis()
        {
            Terrorist maxKey = null!;
            int maxValue = 0;
            foreach(var mostInteligance in terroristInformation)
            {
                if (mostInteligance.Value > maxValue)
                {
                    maxValue = mostInteligance.Value;
                    maxKey = mostInteligance.Key;
                }
            }
            return maxKey!;
            
        }

        //Receiving a list of terrorists returns the most dangerous terrorist
        public Terrorist MostDangoursTerrorist()
        {
            Terrorist mostDangoursTerrorist = null;
            int score = 0;

            foreach ( IntelligenceMessage massege in intelligenceMessages)
            {
                if( massege.terrorist.riskRating > score )
                {
                    score = massege.terrorist.riskRating;
                    mostDangoursTerrorist = massege.terrorist;
                }
            }
            return mostDangoursTerrorist;
        }

        //Receives a terrorist and returns the latest information about him
        public IntelligenceMessage TheLastIntelligance( Terrorist terrorist)
        {
            IntelligenceMessage lastMassage = null;
            foreach (IntelligenceMessage massege in intelligenceMessages)
            {
                if ( massege.terrorist.name == terrorist.name)
                {
                    lastMassage = massege;
                }
            }
            return lastMassage;
        }
        public static Aman StartShow ()
        {
            List<IntelligenceMessage> listMessages = new List<IntelligenceMessage>();
            for (int i = 0; i < 5; i++)
            {
                IntelligenceMessage message = IntelligenceMessage.StartShow();
                listMessages.Add(message);
            }
            Aman newAman = new Aman(listMessages);
            return newAman;
        }

        
    }
    //Defines intelligence information
    public class IntelligenceMessage
    {
        public Terrorist terrorist;
        public string lastLocation;
        public DateTime timeStemp;
        public IntelligenceMessage( Terrorist dangourTerroist, string LastLocation, DateTime TimeStemp)
        {
            terrorist = dangourTerroist;
            lastLocation = LastLocation;
            timeStemp = TimeStemp;
        }

        //Generates an instance of intelligence knowledge with random values
        public static IntelligenceMessage StartShow()
        {

            
            List<DateTime> time = new List<DateTime>
            {
                new DateTime(2025, 5, 25, 6, 12, 0),
                new DateTime(2025, 5, 25, 7, 45, 0),
                new DateTime(2025, 5, 25, 8, 33, 0),
                new DateTime(2025, 5, 25, 9, 15, 0),
                new DateTime(2025, 5, 25, 10, 50, 0),
                new DateTime(2025, 5, 25, 11, 27, 0),
                new DateTime(2025, 5, 25, 12, 5, 0),
                new DateTime(2025, 5, 25, 13, 42, 0),
                new DateTime(2025, 5, 25, 14, 18, 0),
                new DateTime(2025, 5, 25, 15, 30, 0),
                new DateTime(2025, 5, 25, 16, 8, 0),
                new DateTime(2025, 5, 25, 17, 55, 0),
                new DateTime(2025, 5, 25, 18, 25, 0),
                new DateTime(2025, 5, 25, 19, 13, 0),
                new DateTime(2025, 5, 25, 20, 47, 0),
                new DateTime(2025, 5, 25, 21, 22, 0),
                new DateTime(2025, 5, 25, 22, 11, 0),
                new DateTime(2025, 5, 25, 23, 4, 0),
                new DateTime(2025, 5, 25, 23, 40, 0),
                new DateTime(2025, 5, 25, 23, 58, 0)
            };

            List<string> location = new List<string> { "building", "car", "open area" };

            Random rand = new Random();
            DateTime randomTime = time[rand.Next(20)];
            //DateTime randomTime = new DateTime(2025, 
            //    rand.Next(1,13), 
            //    25, 
            //    23, 
            //    58, 
            //    0);

            string randomPlace = location[rand.Next(3)];
            Terrorist terrorist = Terrorist.StartShow();
            IntelligenceMessage newInteliganceMassege = new IntelligenceMessage( terrorist, randomPlace, randomTime);
            return newInteliganceMassege;


        }

    }
}
