using System;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class Equipment : ScriptableObject
    {
        public List<TypeOfEffect> TypesofEffects = new List<TypeOfEffect>();
        public List<EffectType> EquipmentEffects = new List<EffectType>();
        
        public int Cost;

        public virtual void Effect(float value, Transform caster)
        {
            foreach (TypeOfEffect Effect in TypesofEffects)
            {
                switch (Effect)
                {
                    case TypeOfEffect.Heal:
                        EquipmentEffects.Add(new HealEffect(Mathf.RoundToInt(value)));
                        break;
                    case TypeOfEffect.Damage:
                        EquipmentEffects.Add(new DamageEffect(Mathf.RoundToInt(value)));
                        break;
                    case TypeOfEffect.CourageRestore:
                        EquipmentEffects.Add(new RestoreCourage(Mathf.RoundToInt(value)));
                        break;
                    case TypeOfEffect.ManaRestore:
                        EquipmentEffects.Add(new Restoremana(Mathf.RoundToInt(value)));
                        break;
                    case TypeOfEffect.Swap:
                        EquipmentEffects.Add(new SwapPlacesWithTarget(caster));
                        break;
                    case TypeOfEffect.AttackChange:
                        EquipmentEffects.Add(new AttackStatChange(value));
                        break;
                    case TypeOfEffect.DefenceChange:
                        EquipmentEffects.Add(new DefenceStatChange(value));
                        break;
                    case TypeOfEffect.SpecialAhange:
                        EquipmentEffects.Add(new SpecialAttackStatChange(value));
                        break;
                    case TypeOfEffect.SpecialDChange:
                        EquipmentEffects.Add(new SpecialDefenceStatChange(value));
                        break;
                    case TypeOfEffect.SizeChange:
                        EquipmentEffects.Add(new TemporarySizeChangeEffect(value));
                        break;
                    case TypeOfEffect.Cleave:
                        EquipmentEffects.Add(new Cleave());
                        break;
                    case TypeOfEffect.Sap:
                        EquipmentEffects.Add(new Sap(FindObjectOfType<PlayerCombatStats>(), value));
                        break;
                    case TypeOfEffect.SpeedChange:
                        EquipmentEffects.Add(new SpeedChange(value));
                        break;
                    default:
                        Debug.LogWarning("Not an single target spell");
                        break;
                }
            }
        }

        public virtual void Effect(float value1, float value2, LayerMask Layers)
        {
            foreach(TypeOfEffect effect in TypesofEffects)
            {
                switch (effect)
                {
                    case TypeOfEffect.AreaOfEffectDamage:
                        EquipmentEffects.Add(new AreaOfEffectDamage(value1, value2, Layers));
                        break;
                    default:
                        Debug.LogWarning("Not an AOE spell");
                        break; 
                }
            }
        }
    }
}