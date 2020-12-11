using UnityEngine;

namespace Albatross
{
    public class SpecialDefenceStatChange : TempStatChange
    {
        public SpecialDefenceStatChange(float multiplier)
        {
            this.multiplier = multiplier;
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.SpecialDefence = Mathf.RoundToInt(combatStats.SpecialDefence * multiplier);
        }
    }

}