using UnityEngine;

namespace Albatross
{
    public class SecondaryMenus : MonoBehaviour
    {
        public PlayerInventory Inventory = null;
        public GameObject BagTextPrefab = null;

        protected void InstantiateSecMenu(Equipment eq)
        {
            GameObject go = Instantiate(BagTextPrefab, transform);
            go.GetComponent<SecondaryCommand>().Equipment = eq;
            go.GetComponent<SecondaryCommand>().NewCommand();
        }
    }
}