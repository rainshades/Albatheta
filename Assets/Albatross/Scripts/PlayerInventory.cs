using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class PlayerInventory : MonoBehaviour
    {
        public List<Potions> Potions;
        public List<ScriptableObject> Spells;
        public List<Drops> NormalItems;
        public List<CourageSO> CourageSkills; 
    }
}