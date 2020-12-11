using System;

namespace Albatross
{
    [Serializable]
    public class Restoremana : EffectType
    {
        public int RestoreAmount = 0;
        public Restoremana(int RestoreAmount){
            this.RestoreAmount = RestoreAmount;
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            if (combatStats.Mana < combatStats.MaxMana - RestoreAmount)
                combatStats.Mana += RestoreAmount;
            else
                combatStats.Mana = combatStats.MaxMana;
        }
    }
}
