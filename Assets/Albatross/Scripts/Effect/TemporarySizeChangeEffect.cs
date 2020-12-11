namespace Albatross
{
    public class TemporarySizeChangeEffect : EffectType
    {
        float SizeModifier = 0; 
        public TemporarySizeChangeEffect(float SizeModifier)
        {
            this.SizeModifier = SizeModifier; 
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            combatStats.transform.localScale *= SizeModifier; 
        }
    }

}