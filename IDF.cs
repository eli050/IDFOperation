using System;

namespace IDFOperation.IDFClasses
{
    public class IDF
    {
        public string dateOfEstablishment = "1948";
        private string currentCommander;
        private List<AttackOption> attacks;
        public IDF(string CurrentCommander
            , List<AttackOption> Attacks)
        {
            currentCommander = CurrentCommander;
            attacks = Attacks;
        }
        public bool AddStrike(AttackOption strike)
        {
            attacks.Add(strike);
            return true;
        }
        public Dictionary<string, int> GetStrikeAndArsenal()
        {
            Dictionary<string, int> arsenal = new Dictionary<string, int>();
            foreach (AttackOption attack in attacks)
            {
                if (arsenal.ContainsKey(attack.uniqueName))
                {
                    arsenal[$"{attack.uniqueName}2"] = attack.ammunitionCapacity;
                }
                else
                {
                    arsenal[attack.uniqueName] = attack.ammunitionCapacity;
                }
            }
            return arsenal;
        }
        static IDF StartShow()
        {
            List<AttackOption> attacks = new List<AttackOption>();
            IDF show = new IDF("eli", attacks);
            return show;
        }

    }
    public abstract class AttackOption
    {
        public string uniqueName { get; }
        public int ammunitionCapacity;
        protected long fuelSupply;
        protected List<string> effectiveAgainst;
        protected string bombType;
        public AttackOption(string UniqeName,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType)
        {
            uniqueName = UniqeName;
            ammunitionCapacity = AmmunitionCapacity;
            fuelSupply = FuelSupply;
            effectiveAgainst = EffectiveAgainst;
            bombType = BombType;
        }
        static AttackOption StartShow()
        {
            var valuesByType = new Dictionary<Type,
                 List<(string uniqueName,
                       int ammunitionCapacity,
                       long fuelSupply,
                       List<string> effectiveAgainst,
                       string bombType)>>()
{
    { typeof(Fighter),   new List<(string,int,long,List<string>,string)>
                         { ("F16",        8, 12000L, new List<string>{ "Buildings" },                "0.5 t / 1 t GP") } },

    { typeof(Drone),     new List<(string,int,long,List<string>,string)>
                         { ("Hermes 460", 3,  6000L, new List<string>{ "Personnel", "Light-armor" }, "Modular (HE / AT)") } },

    { typeof(Artillery), new List<(string,int,long,List<string>,string)>
                         { ("M109",      40,     0L, new List<string>{ "Open terrain" },             "High-explosive shell") } },
};
        }
    }
    public class Fighter : AttackOption
    {
        public Fighter(string UniqeName,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType) : base(UniqeName,
                AmmunitionCapacity, FuelSupply,
                EffectiveAgainst, BombType)
        {

        }
    }
    public class Drone : AttackOption
    {
        public Drone(string UniqeName,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType) : base(UniqeName,
                AmmunitionCapacity, FuelSupply,
                EffectiveAgainst, BombType)
        {

        }
    }
    public class Artillery : AttackOption
    {
        public Artillery(string UniqeName,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType) : base(UniqeName,
                AmmunitionCapacity, FuelSupply,
                EffectiveAgainst, BombType)
        {

        }
    }
}
