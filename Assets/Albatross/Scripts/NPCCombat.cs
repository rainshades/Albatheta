using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class NPCCombat : CharacterCombat
    {
        private void Start()
        {
            Attacks.Add(new ComboFinisher(HitBox, attackRange, EnemyLayers, combatStats, this, aninmator, "Attack"));
        }

        public override void Attack()
        {
            Attacks[Attack_ani_iterator].PlayAnimation();
        }

        private void LateUpdate()
        {
            if (combatStats.Health <= 0)
            {
                Die();
            }
        }

        protected override void Die()
        {
            base.Die();
            aninmator.Play("Dying");
        }

        protected override void Kill()
        {
            if (GetComponent<CharacterController>())
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(transform.parent.gameObject);
            }
        }

        private void Update()
        {
            if (isAlive)
            {
                Collider[] hitenemies = Physics.OverlapSphere(HitBox.position, attackRange, EnemyLayers);
                foreach (Collider enemy in hitenemies)
                {
                    if (Time.time >= nextAttackTime && enemy.GetComponent<CharacterCombat>().combatStats.Health > 0)
                    {
                        Attack();
                        nextAttackTime = Time.time + 1f / attackRate;
                    }
                }
            }
        }
    }
}