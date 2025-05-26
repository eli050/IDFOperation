using System;
using IDFOperation.AmanClasses;
using IDFOperation.IDFClasses;
using IDFOperation.HamasClasses;

namespace IDFOperation
{
    public class Attack
    {
        //public Terrorist dangourTerrorist;
        public Aman amanShow;
        public IDF IdfShow;
        public Hamas hamasShow;
        public Attack(Aman AmanShow,IDF IDFShow,Hamas HamasShow)
        {
            amanShow = AmanShow;
            IdfShow = IDFShow;
            hamasShow = HamasShow;
            //dangourTerrorist = MostDangoursTerrorist();
        }
        public AttackOption RelevantUnit()
        {
            Terrorist dangourTerrorist = amanShow.MostDangoursTerrorist();
            IntelligenceMessage message = amanShow.intelligenceMessages[0];
            foreach (IntelligenceMessage intelligenceMessage in amanShow.intelligenceMessages)
            {
                
                if (intelligenceMessage.terrorist == dangourTerrorist)
                {
                    message = intelligenceMessage;
                    break;
                }
            }

            switch (message.lastLocation)
            {
                case "building":
                    return 
                    break;
                case "car":
                    break;
                case "open area":
                    break;

            }

        }
        public bool StartAttack()
        {
            return true;
        }
    }
}
