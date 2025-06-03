using System;

namespace IDFOperation.IDFClasses
{
    public class IDF
    {
        public string dateOfEstablishment = "1948";
        private string currentCommander;
        public Dictionary<string,AttackOption> attacks;
        public IDF(string CurrentCommander
            , Dictionary<string,AttackOption> Attacks)
        {
            currentCommander = CurrentCommander;
            attacks = Attacks;
        }
        public bool AddStrike(AttackOption strike)
        {
            attacks[strike.uniqueName] = strike;
            return true;
        }
        public Dictionary<string, int> GetStrikeAndArsenal()
        {
            Dictionary<string, int> arsenal = new Dictionary<string, int>();
            foreach (string attack in attacks.Keys)
            {
                if (attacks[attack].ammunitionCapacity > 0)
                    if (arsenal.ContainsKey(attack))
                    {
                            arsenal[attack] += attacks[attack].ammunitionCapacity;
                    }
                    else
                    {
                            arsenal[attack] = attacks[attack].ammunitionCapacity;
                    }
                else
                {
                    DeleteStrike(attack);
                }
            }
            return arsenal;
        }
        public static IDF StartShow()
        {
            Dictionary<string, AttackOption> attacks = new Dictionary<string, AttackOption>() 
            {
                ["F16"] = Fighter.StartShow(),
                ["Hermes 460"] = Drone.StartShow(),
                ["M109"] =Artillery.StartShow()
            };
            IDF show = new IDF("eyal zamir", attacks);
            return show;
        }
        public void DeleteStrike(string attack)
        {
            attacks.Remove(attack); 
        }

    }
    public abstract class AttackOption
    {
        public string uniqueName { get; }
        private int ammunitioncapacity;
        public int ammunitionCapacity
        {
            get
            {
                return ammunitioncapacity;
            }
             
            set
            {
                if (value > 0)
                {
                     ammunitioncapacity = value;
                }
                else
                {
                    ammunitioncapacity = 0;
                }
            }
        }
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
        public static Fighter StartShow()
        {
            Fighter show = new Fighter("F16", 8, 12000L, new List<string> { "Buildings" }, "0.5 t / 1 t GP");
            return show;
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
        public static Drone StartShow()
        {
            Drone show = new Drone("Hermes 460", 3, 6000L, new List<string> { "people", "vehicles" }, "Modular (HE / AT)");
            return show;
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
        public static Artillery StartShow()
        {
            Artillery show = new Artillery("M109", 40, 0L, new List<string> { "open areas" }, "High-explosive shell");
            return show;
        }
    }
}
