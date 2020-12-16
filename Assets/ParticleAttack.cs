using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Albatross
{
    public class ParticleAttack : MonoBehaviour
    {

        [SerializeField]
        CourageSO AttackEffect; 

        public CourageSO AE { get => AttackEffect; set => AttackEffect = value; }

        float AttackSpeed = 3.0f; 

        float MaxTimeAlive = 5.0f;

        void FixedUpdate()
        {

            MaxTimeAlive -= Time.deltaTime;

            ParticleSystem PS = GetComponent<ParticleSystem>();

            if (MaxTimeAlive <= 0)
            {
                Debug.Log("Fizzle");
                Destroy(gameObject);
            }

            transform.Translate( AttackSpeed * Vector3.forward * Time.deltaTime);

        }


        private void OnCollisionEnter(Collision collision)
        {

            if (collision.transform.CompareTag("Enemy"))
            {
                
                CharacterCombatStats stat = collision.gameObject.GetComponent<CharacterCombatStats>();
                if (stat == null)
                {
                    stat = collision.transform.GetComponentInChildren<CharacterCombatStats>();
                }
                AttackEffect.Effect(AttackEffect.damagevalue, FindObjectOfType<PlayerCombatStats>().transform);
                foreach (EffectType Effect in AttackEffect.EquipmentEffects)
                {
                    Effect.FireEffect(stat);
                }

                Destroy(gameObject);
            }
        }
    }
}