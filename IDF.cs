using System;

namespace IDFOperation.IDFClasses
{
    public class IDF
    {
        private string dateOfEstablishment;
        private string currentCommander;
        private List<AttackOption> attacks;
        public IDF(string DateOfEstablishment, string CurrentCommander 
            , List<AttackOption> Attacks)
        {
            dateOfEstablishment = DateOfEstablishment;
            currentCommander = CurrentCommander;
            attacks = Attacks;
        }

    }
   public abstract class AttackOption
    {
        protected string uniqueName;
        protected int ammunitionCapacity;
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
