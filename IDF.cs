using System;

namespace IDFOperation.IDFClasses
{
    public class IDF
    {
        private string dateOfEstablishment;
        private string currentCommander;
        // List of attack options
        public IDF(string DateOfEstablishment, string CurrentCommander)
        {
            dateOfEstablishment = DateOfEstablishment;
            currentCommander = CurrentCommander;
            // List of attack options
        }

    }
    abstract class AttackOption
    {
        private string uniqueName;
        private int ammunitionCapacity;
        private long fuelSupply;
        private List<string> effectiveAgainst;
        public AttackOption(string UniqeName ,
            int AmmunitionCapacity, long FuelSupply,
            List<string> EffectiveAgainst)
        {
            uniqueName = UniqeName;
            ammunitionCapacity = AmmunitionCapacity;
            fuelSupply = FuelSupply;
            effectiveAgainst = EffectiveAgainst;
        }
    }
}
