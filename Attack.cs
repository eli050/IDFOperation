/*
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
            Console.WriteLine($"Date of attack: {dateTime}\n" +
                $"Operations officer: {name}\n" +
                $" Attack with attack unit {RelevantUnit().uniqueName}\n" +
                $" on terrorist {dangourTerrorist}\n " +
                $"with latest location is {lastMessage.lastLocation}\n" +
                $"Time of intelligence receipt: {lastMessage.timeStemp}\n" +
                $"Ready to execute");      
        }
    }
}
*/