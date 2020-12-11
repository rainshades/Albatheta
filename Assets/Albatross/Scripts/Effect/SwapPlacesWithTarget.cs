using System;
using UnityEngine;

namespace Albatross
{
    [Serializable]
    public class SwapPlacesWithTarget : EffectType
    {
        public Transform Player; 
        public SwapPlacesWithTarget(Transform Player)
        {
            this.Player = Player; 
        }
        public override void FireEffect(CharacterCombatStats combatStats)
        {
            Vector3 PlaceholderVerticies;
            PlaceholderVerticies = Player.position;
            Player.position = combatStats.transform.position;
            combatStats.transform.position = PlaceholderVerticies; 
        }
    }
}