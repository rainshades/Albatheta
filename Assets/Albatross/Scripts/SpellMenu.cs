using UnityEngine; 
namespace Albatross
{
    public class SpellMenu : SecondaryMenus
    {
        public void DrawHand()
        {
            if (transform.childCount == 0)
                for (int i = 0; i < 4; i++)
                {
                    int cardPull = Random.Range(0, Inventory.Spells.Count);
                    InstantiateSecMenu(Inventory.Spells[i] as SpellSO);
                }
        }
    }
}