using UnityEngine;

namespace Albatross
{
    public class MorphSize : EffectType
    {
        Transform transform; 
        float ScaleUpValue;
        
        public MorphSize(Transform TransformToChange, float ScaleUpSize)
        {
            transform = TransformToChange;
            ScaleUpValue = ScaleUpSize; 
        }

        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.transform.localScale *= ScaleUpValue;
        }

    }
}