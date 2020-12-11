using UnityEngine;

namespace Albatross
{
    public class Attack
    {
        protected Transform hitbox; 
        protected float AttackRange; 
        protected LayerMask EnemyLayers; 
        protected CharacterCombatStats Stats;
        protected CharacterCombat Combat;
        protected Animator Ani;
        protected string AttackAnimation; 

        protected bool Blocked;

        public Attack(Transform hitbox, float AttackRange, LayerMask EnemyLayers, CharacterCombatStats Stats, CharacterCombat Combat, Animator Ani, string AttackAnimation)
        {
            this.hitbox = hitbox; this.AttackRange = AttackRange; this.EnemyLayers = EnemyLayers; this.Stats = Stats; this.Combat = Combat; this.Ani = Ani; this.AttackAnimation = AttackAnimation;
        }

        public virtual void HitOpponent()
        {
            Collider[] hitenemies = Physics.OverlapSphere(hitbox.position, AttackRange, EnemyLayers);

            foreach (Collider enemy in hitenemies)
            {
                if(enemy.GetComponent<CharacterCombat>())
                    Blocked = enemy.GetComponent<CharacterCombat>().isBlocking; 
                else if (enemy.GetComponentInChildren<CharacterCombat>())
                {
                    Blocked = enemy.GetComponentInChildren<CharacterCombat>().isBlocking;
                }

                if (!Blocked)
                {
                    if (enemy.GetComponent<CharacterCombat>())
                    {
                        enemy.GetComponent<CharacterCombat>().TakeDamage(Stats.Attack);
                    }
                    else if(enemy.GetComponentInChildren< CharacterCombat>())
                    {
                        enemy.GetComponentInChildren<CharacterCombat>().TakeDamage(Stats.Attack);
                    }
                }
            }
            Combat.Attack_ani_iterator++;
        }

        public virtual void PlayAnimation()
        {
            Ani.Play(AttackAnimation);
        }
    }
}