using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    [CreateAssetMenu(fileName = "New Drop", menuName = "Drop")]
    public class Drops : ItemSO
    {
        public ItemSO ItemToDrop;
        public bool RestoreDrop;
        public int count; 
    }
}