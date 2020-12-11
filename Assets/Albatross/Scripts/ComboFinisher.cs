using UnityEngine;

namespace Albatross
{
    public class ComboFinisher : Attack
    {
        public ComboFinisher(Transform hitbox, float AttackRange, LayerMask EnemyLayers, 
            CharacterCombatStats Stats, CharacterCombat combat, Animator Ani, string AttackAnimation) : base(hitbox, AttackRange, EnemyLayers, Stats, combat, Ani, AttackAnimation)
        {
            this.hitbox = hitbox; this.AttackRange = AttackRange; this.EnemyLayers = EnemyLayers; this.Stats = Stats; this.Combat = combat; this.Ani = Ani; this.AttackAnimation = AttackAnimation;
        }

        public override void HitOpponent()
        {
            Collider[] hitenemies = Physics.OverlapSphere(hitbox.position, AttackRange, EnemyLayers);

            foreach (Collider enemy in hitenemies)
            {
                if (enemy.GetComponent<CharacterCombat>() != null)
                {
                    enemy.GetComponent<CharacterCombat>().TakeDamage(Stats.Attack);
                }
                else
                {
                    enemy.GetComponentInChildren<CharacterCombat>().TakeDamage(Stats.Attack);
                }
                
                Vector3 KnockBackDirection = (hitbox.position - enemy.transform.position) * -1;
                KnockBackDirection = KnockBackDirection.normalized;
                KnockBackCalc(enemy.GetComponent<CharacterMovementObject>(), KnockBackDirection);

                Combat.ResetAttackAnimation(); 

            }
        }

        void KnockBackCalc(CharacterMovementObject target, Vector3 direction)
        {
            target.KnockBack(direction);
        }
    }
}