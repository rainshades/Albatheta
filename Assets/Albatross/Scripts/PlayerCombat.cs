using UnityEngine;

namespace Albatross
{
    public class PlayerCombat : CharacterCombat
    {

        private void Start()
        {
            Attacks.Add(new Attack(HitBox, attackRange, EnemyLayers, combatStats, this, aninmator, "AttackOne"));
            Attacks.Add(new Attack(HitBox, attackRange, EnemyLayers, combatStats, this, aninmator, "AttackTwo"));
            Attacks.Add(new ComboFinisher(HitBox, attackRange, EnemyLayers, combatStats, this, aninmator, "AttackFinish"));
        }
        public override void Attack()
        {
            Attacks[Attack_ani_iterator].PlayAnimation();
            PlayerMovementControls PMC = GetComponent<PlayerMovementControls>();
            PMC.EndWalkState();
            PMC.Thrust();
        }

        private void Update()
        {
            if(combatStats.Health <= 0)
            {
                Die();
            }
        }

        protected override void Die()
        {
            GameManager.Instance.Pause(); 
            CanvasManager.Instance.GameOver();
        }

        public void Emit(ParticleSystem particle)
        {
            Instantiate(particle, HitBox.position, HitBox.rotation);
        }
    }
}