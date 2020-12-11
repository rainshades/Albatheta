using System;
using UnityEngine;

namespace Albatross
{
    [Serializable]
    public class DamageEffect : EffectType
    {
        public int DamageAmount = 0;
        public DamageEffect(int DamageAmount)
        {
            this.DamageAmount = DamageAmount;
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Health -= DamageAmount;
            GameObject.FindObjectOfType<EnemyUIHealthCheck>().LastEnemyAttacked = combatStats.gameObject;
        }
    }
}