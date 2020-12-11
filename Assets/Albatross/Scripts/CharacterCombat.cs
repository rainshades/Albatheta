using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class CharacterCombat : MonoBehaviour
    {
        protected Animator aninmator;
        public CharacterCombatStats combatStats;

        public Transform HitBox;
        public float attackRange = 0.5f;

        public LayerMask EnemyLayers;

        public float attackRate = 2f;
        public float nextAttackTime = 0;
        public int Attack_ani_iterator = 0;

        protected bool isAlive = true;
        public bool isBlocking = false; 

        protected List<Attack> Attacks = new List<Attack>();

        private void Awake()
        {
            if (GetComponent<Animator>())
                aninmator = GetComponent<Animator>();
            else
                aninmator = GetComponentInChildren<Animator>();

            
            if(GetComponent<CharacterCombatStats>())
                combatStats = GetComponent<CharacterCombatStats>();
            else
            {
                combatStats = GetComponentInChildren <CharacterCombatStats>();
            }
        }

        public void HitOpponent()
        {
            Attacks[Attack_ani_iterator].HitOpponent();
        }

        public virtual void Attack()
        {
        }

        public virtual void Block()
        {
            isBlocking = true; 
        }
        public virtual void BlockEnd()
        {
            isBlocking = false; 
        }

        public void ResetAttackAnimation()
        {
            Attack_ani_iterator = 0;
        }

        public void Cast(SpellSO SpellCard)
        {
            if(combatStats.Mana - SpellCard.Cost >= 0)
                combatStats.Mana -= SpellCard.Cost;
            
            aninmator.SetBool("In combat", true);
        }

        public void Cast(CourageSO CourageAbility)
        {
            if (combatStats.Courage - CourageAbility.Cost >= 0)
                combatStats.Courage -= CourageAbility.Cost;

            aninmator.SetBool("In combat", true);
        }

        private void OnDrawGizmosSelected()
        {
            if (HitBox == null)
                return;

            Gizmos.DrawWireSphere(HitBox.position, attackRange);
        }

        public void TakeDamage(int damage)
        {
            combatStats.Health -= damage;
            aninmator.Play("TookDamage");
        }

        protected virtual void Die()
        {
            isAlive = false;
        }

        protected virtual void Kill()
        {
        }
    }
}