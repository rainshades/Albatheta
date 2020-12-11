using System;

namespace Albatross
{
    [Serializable]
    public class HealEffect : EffectType
    {
        public int HealAmount = 0;
        public HealEffect(int HealAmount)
        {
            this.HealAmount = HealAmount; 
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            if (combatStats.Health < combatStats.MaxHealth - HealAmount)
                combatStats.Health += HealAmount;
            else
                combatStats.Health = combatStats.MaxHealth;
        }
    }
}
