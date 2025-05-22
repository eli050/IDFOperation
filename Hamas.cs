using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HamasClasses
{
    public class Hamas
    {
        private string commander;
        private string YearOfEstablishment = "1988";
        private List<Terrorist> terrorists;
        public Hamas(string Commander, List<Terrorist> Terrorists)
        {
            commander = Commander;
            terrorists = Terrorists;
        }
    }
    public class Terrorist
    {
        private string name;
        private int runk;
        private string status;
        private List <string> weapons;
        public Terrorist(string Name, int Runk, string Status, List< string> Weapons)
        {
            name = Name;
            runk = Runk;
            weapons = Weapons;
            status = Status;
            Dictionary<string, int> weaponRating = new Dictionary<string, int>();
        }
        public int RiskRating()
        {
            int dangerous = 0;
            return dangerous;
        }
        public int WeaponsRating()
        {
            foreach(string weapon in weapons)
            {
                return 0;
            }
            return 0;
        }
    }
}
