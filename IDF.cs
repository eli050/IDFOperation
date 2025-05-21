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
        private string uniqueName;
        private int ammunitionCapacity;
        private long fuelSupply;
        private List<string> effectiveAgainst;
        private string bombType;
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
}
