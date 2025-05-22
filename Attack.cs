using System;
using IDFOperation.AmanClasses;
using IDFOperation.IDFClasses;
using IDFOperation.HamasClasses;

namespace IDFOperation
{
    public class Attack
    {
        public Terrorist dangourTerrorist;
        public Attack()
        {
            dangourTerrorist = MostDangoursTerrorist();
        }
        public AttackOption RelevantUnit()
        {
            AttackOption relevantunit;
            return relevantunit;
        }
        public bool StartAttack()
        {
            return true;
        }
    }
}
