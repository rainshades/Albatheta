using UnityEngine;

namespace Albatross
{
    public class TemporaryTransformCharacterEffect : EffectType
    {
        GameObject TempTransformation;
        float timer;
        public TemporaryTransformCharacterEffect(GameObject NewTransform)
        {
            TempTransformation = NewTransform; 
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
        }
    }

}