using UnityEngine;

namespace Albatross
{
    public class DefenceStatChange : TempStatChange
    {

        public DefenceStatChange(float multiplier)
        {
            this.multiplier = multiplier;
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Defence = Mathf.RoundToInt(combatStats.Defence * multiplier);
        }
    }

}