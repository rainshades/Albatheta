using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Albatross
{
    //Slow Spells are heavy and have low range
    //Quick Spells are homing and so they are too quick to dodge
    //Equipment Spells are self cast but character must stop to castPlayerTransfoic class SpellCardObject : MonoBehaviour
    public class SpellCardObject : MonoBehaviour
    {
        public SpellSO SpellCard = null;

        Rigidbody rbd;
        [SerializeField]
        GameObject[] Enemies;

        float cardSpeed;

        [SerializeField]
        ParticleSystem ImpactParticleEffect = null;

        [SerializeField]
        GameObject target;

        public LayerMask HitLayers;

        float MaxTimeAlive = 5.0f;

        public GameObject Target { set => target = value; }

        private void Awake()
        {
            rbd = GetComponent<Rigidbody>();

            Enemies = GameObject.FindGameObjectsWithTag("Enemy");

            cardSpeed = SpellCard.Speed;
        }

        private void FixedUpdate()
        {
            MaxTimeAlive -= Time.deltaTime; 

            if(MaxTimeAlive <= 0)
            {
                Debug.Log("Spell Fizzle");
                Destroy(gameObject);
            }


            if (SpellCard is QuickSpell)
            {
                rbd.constraints = RigidbodyConstraints.FreezePositionY;
                rbd.useGravity = false;

                target = EnemyUIHealthCheck.Instance.LastEnemyAttacked;

                if (target == null)
                {
                    float Targetpos = 0;

                    foreach (GameObject enemy in Enemies)
                    {
                        float Dot = Vector3.Dot(transform.position, enemy.transform.position);
                        if (Dot < Targetpos)
                        {
                            Targetpos = Dot; 
                            Target = enemy;
                        }
                    }

                }

                if (target != null)
                {
                    transform.LookAt(target.transform);
                    transform.Translate(Vector3.forward * cardSpeed * Time.deltaTime);
                }
                else
                {
                    Debug.Log("Targets empty");
                }

            }

            if(SpellCard is SlowSpell)
            {
                rbd.velocity += cardSpeed * cardSpeed * Vector3.forward * Time.deltaTime;
            }

        }

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision: " + collision.transform.tag);

            if (collision.transform.CompareTag("Enemy"))
            {
                Instantiate(ImpactParticleEffect, transform.position, Quaternion.identity);
                SpellCard.Effect(SpellCard.Damage, collision.transform);
                foreach(EffectType effect in SpellCard.EquipmentEffects)
                {
                    CharacterCombatStats stat = collision.gameObject.GetComponent<CharacterCombatStats>();
                    if (stat == null)
                    {
                        stat = collision.transform.GetComponentInChildren<CharacterCombatStats>();
                    }

                    try
                    {
                        effect.FireEffect(stat);
                    }
                    catch
                    {
                        Debug.LogWarning("Character Combat Stat not found");
                    }
                }
            }

            if (collision.transform.CompareTag("Ground") && SpellCard is SlowSpell)
            {
                Instantiate(ImpactParticleEffect, transform.position, Quaternion.identity);
                SpellCard.Effect(SpellCard.Damage, SpellCard.AreaOfEffect, HitLayers);
            }
            else if (collision.transform.CompareTag("Ground"))
            {
                Instantiate(ImpactParticleEffect, transform.position, Quaternion.identity);
            }


            Destroy(gameObject);
        }

        public void SetCard(SpellSO Spell)
        {
            SpellCard = Spell;
        }

        protected virtual void Damage_Target(CharacterCombatStats CCS)
        {
            CCS.Health -= SpellCard.Damage;
        }
    }
}