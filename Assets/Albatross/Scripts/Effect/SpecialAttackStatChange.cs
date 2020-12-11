using UnityEngine;

namespace Albatross
{
    public class SpecialAttackStatChange : TempStatChange
    {

        public SpecialAttackStatChange(float multiplier)
        {
            this.multiplier = multiplier;
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Special = Mathf.RoundToInt(combatStats.Special * multiplier);
        }
    }

}