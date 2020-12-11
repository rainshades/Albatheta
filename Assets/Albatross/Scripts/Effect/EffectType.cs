using System;
using UnityEngine;

namespace Albatross
{
    [Serializable]
    public abstract class EffectType
    {
        public abstract void FireEffect(CharacterCombatStats combatStats);
    }


    public class Cleave : EffectType
    {
        public Cleave()
        {

        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Health /= 2; 
        }
    }

    public class Sap : EffectType
    {
        PlayerCombatStats PlayerStats;
        float damage; 

        public Sap(PlayerCombatStats PlayerStats, float damage)
        {
            this.PlayerStats = PlayerStats; this.damage = damage; 
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.Health = Mathf.RoundToInt(combatStats.Health - damage);
            PlayerStats.Health = Mathf.RoundToInt(PlayerStats.Health + damage);

        }
    }

    public class SpeedChange : EffectType
    {
        float change; 
        
        public SpeedChange(float change)
        {
            this.change = change; 
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            CharacterMovementData MovementStats = combatStats.GetComponent<CharacterMovementData>();
            
            if (MovementStats)
            {
                MovementStats.Movement_speed *= change; 
            }
        }
    }

    public class AreaOfEffectDamage : EffectType
    {
        float Damage, AreaOfEffect;
        LayerMask EnemyLayermask;
        
        public AreaOfEffectDamage(float Damage, float AreaOfEffect, LayerMask EnemyLayermask)
        {
            this.Damage = Damage; this.AreaOfEffect = AreaOfEffect; this.EnemyLayermask = EnemyLayermask; 
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
        }

        public void FireEffect(Collider collision)
        {
            Collider[] DamageArea = Physics.OverlapSphere(collision.transform.position, AreaOfEffect, EnemyLayermask);

            foreach(Collider enemy in DamageArea)
            {
                CharacterCombatStats Hit = enemy.GetComponent<CharacterCombatStats>();
                if(Hit == null)
                {
                    Hit = enemy.GetComponentInChildren<CharacterCombatStats>();
                }

                try
                {
                    Hit.Health = Mathf.RoundToInt(Hit.Health - Damage);
                }
                catch
                {
                    Debug.LogWarning("No collisions detected");
                }
            }
        }
    }
}