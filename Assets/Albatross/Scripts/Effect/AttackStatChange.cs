using UnityEngine;

namespace Albatross
{
    public class AttackStatChange : TempStatChange
    {
        public AttackStatChange(float multiplier)
        {
            this.multiplier = multiplier; 
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Attack = Mathf.RoundToInt(combatStats.Attack * multiplier); 
        }
    }

}