using System;

namespace Albatross
{
    [Serializable]
    public class RestoreCourage : EffectType
    {
        public int RestoreAmount = 0; 
        public RestoreCourage(int RestoreAmount)
        {
            this.RestoreAmount = RestoreAmount; 
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            if (combatStats.Courage < combatStats.MaxCourage - RestoreAmount)
                combatStats.Courage += RestoreAmount;
            else
                combatStats.Courage = combatStats.MaxCourage;
        }
    }
}
