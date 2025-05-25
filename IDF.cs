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
        public Dictionary<string,int> GetStrikeAndArsenal()
        {
            Dictionary<string, int> arsenal = new Dictionary<string, int>();
            foreach(AttackOption attack in attacks)
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
            List < AttackOption > attacks = new List<AttackOption>();
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
        public AttackOption(string UniqeName ,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType)
        {
            uniqueName = UniqeName;
            ammunitionCapacity = AmmunitionCapacity;
            fuelSupply = FuelSupply;
            effectiveAgainst = EffectiveAgainst;
            bombType = BombType;
        }
    }
    public class Fighter: AttackOption
    {
        public Fighter(string UniqeName,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst, string BombType): base(UniqeName ,
                AmmunitionCapacity, FuelSupply,
                EffectiveAgainst, BombType)
        {

        }
    }
    public class Drone: AttackOption
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
