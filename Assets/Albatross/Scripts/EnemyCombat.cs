using UnityEngine;

namespace Albatross
{
    public class EnemyCombat : NPCCombat
    {
        public DropPrize loot;

        DropPrize AttatchedPrize; 

        protected override void Kill()
        {
            AttatchedPrize = GetComponent<DropPrize>();
            DropPrize Loot = Instantiate(loot, transform);
            Loot.Items[0] = (AttatchedPrize.Items[Random.Range(0, AttatchedPrize.Items.Count)]);
            var main = Loot.GetComponentInChildren<ParticleSystem>().main;
            
            foreach(Drops item in Loot.Items)
            {
                foreach(TypeOfEffect EffectType in item.TypesofEffects)
                {
                    if(EffectType == TypeOfEffect.Heal || EffectType == TypeOfEffect.ManaRestore || 
                        EffectType == TypeOfEffect.CourageRestore)
                    {
                        item.RestoreDrop = true; 
                    }
                }
            }

            switch (Loot.Items[0].TypesofEffects[0]) 
            {
                case TypeOfEffect.Heal:
                    main.startColor = new Color(1.0f, 0, 0, 0.5f);
                    break;
                case TypeOfEffect.ManaRestore:
                    main.startColor = new Color(0, 0, 1.0f, 0.5f);
                    break;
                case TypeOfEffect.CourageRestore:
                    main.startColor = new Color(1.0f, 1.0f, 0, 0.5f);
                    break;
                default:
                    main.startColor = new Color(0, 0, 0, 0);
                    break; 
            }

            Loot.transform.parent = null;
            base.Kill();
        }
    }
}