using System;
using IDFOperation.AmanClasses;
using IDFOperation.IDFClasses;
using IDFOperation.HamasClasses;

namespace IDFOperation
{
    public class Attack
    {
        public Terrorist dangourTerrorist;
        public Aman amanShow;
        public IDF IdfShow;
        public Hamas hamasShow;
        public IntelligenceMessage lastMessage;
        public Attack(Aman AmanShow,IDF IDFShow,Hamas HamasShow)
        {
            amanShow = AmanShow;
            IdfShow = IDFShow;
            hamasShow = HamasShow;
            dangourTerrorist = amanShow.MostDangoursTerrorist();
            lastMessage = amanShow.TheLastIntelligance(dangourTerrorist);
            
        }
        public AttackOption? RelevantUnit()
        {
            switch (lastMessage.lastLocation)
            {
                case "building":
                    return IdfShow.attacks["F16"];
                case "car":
                    return IdfShow.attacks["Hermes 460"];
                case "open area":
                    return IdfShow.attacks["M109"];
                default:
                    return null;

            }
        }
        public void StartAttack()
        {
            
            Console.WriteLine("Enter oficcer name: ");
            string name = Console.ReadLine()!;
            DateTime dateTime = DateTime.Now;
            AttackOption attackOption = RelevantUnit();
            Console.WriteLine($"\nDate of attack: {dateTime}\n" +
                $"Officer: {name}\n" +
                $"Attack unit: {attackOption.uniqueName}\n" +
                $"Target:  {dangourTerrorist.name}\n " +
                $"Location: {lastMessage.lastLocation}\n" +
                $"Intel date: {lastMessage.timeStemp}\n" 
                );
            attackOption.ammunitionCapacity -= 1;

        }
    }
}
