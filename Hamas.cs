using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HamasClasses
{
    //Provides information about the Hamas terror closet
    public class Hamas
    {
        public string commander;
        public string YearOfEstablishment = "1988";
        public List<Terrorist> terrorists = new List<Terrorist>();
        public Hamas(string Commander ,List<Terrorist> Terrorists)
        {
            commander = Commander;
            terrorists = Terrorists;
        }
        public bool AddTerroris(Terrorist terorist)
        {
            terrorists.Add(terorist);
            return true;
        }
        public static Hamas StartShow()
        {
            List<Terrorist> terrorist = new List<Terrorist>();
            Hamas show = new Hamas("azadin el hadad", terrorist);
            for (int _ = 0; _ < 5; _++)
            {
                show.AddTerroris(Terrorist.StartShow());
            }
            return show;
        }
    }
    public class Terrorist
    {
        public string name { get; }
        public int runk { get;}
        public string status { get; }
        private List <string> weapons;
      static  Dictionary<string, int> weaponRating = new Dictionary<string, int>
      {
          ["knife"] = 1,
          ["gun"] = 2,
          ["M16"] = 3,
          ["AK47"] = 3
      };
        public int riskRating;
        public Terrorist(string Name, int Runk, string Status, List<string> Weapons)
        {
            name = Name;
            runk = Runk;
            weapons = Weapons;
            status = Status;
            riskRating = RiskRating();
            //weaponRating = new Dictionary<string, int>()
            //{
            //    ["knife"] = 1,
            //    ["gun"] = 2,
            //    ["M16"] = 3,
            //    ["AK47"] = 3
            //};
        }
        public int RiskRating()
        {
            int dangerous = runk * _WeaponsRating();
            return dangerous;
        }
        private int _WeaponsRating()
        {
            int sumRating = 0;
            foreach(string weapon in weapons)
            {
                sumRating += weaponRating[weapon];
            }
            return sumRating;
        }
        public static Terrorist StartShow()
        {
            Random rund = new Random();
            string[] statuses = new string[]
            {
                "live",
                "dead"
            }; 
            List<string> guns = new List<string>()
            {
                "knife",
                "gun",
                "M16",
                "AK47"
            };
            List<string> gunsT = new List<string>();
            gunsT.Add(guns[rund.Next(guns.Count)]);
            gunsT.Add(guns[rund.Next(guns.Count)]);
            List<string> Terrorists = new()
            {
            "Osama bin Laden",
            "Ayman al-Zawahiri",
            "Abu Bakr al-Baghdadi",
            "Abu Musab al-Zarqawi",
            "Khalid Sheikh Mohammed",
            "Ramzi Yousef",
            "Mohammed Deif",
            "Ismail Haniyeh",
            "Hassan Nasrallah",
            "Imad Mughniyeh",
            "Salah Abdeslam",
            "Abdul Rahman Yasin",
            "Anders Behring Breivik",
            "Baruch Goldshtain"
            };
            string name = Terrorists[rund.Next(Terrorists.Count)];
            int runk = rund.Next(10);
            string status = statuses[rund.Next(2)];
            Terrorist terrorist = new Terrorist(name, runk, status, gunsT);
            return terrorist;
        }
 
    }
}
