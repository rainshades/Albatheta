namespace Albatross
{
    public class ItemMenu : SecondaryMenus
    {
        private void Awake()
        {
            if (transform.childCount == 0)
                foreach (ItemSO Item in Inventory.Potions)
                {
                    InstantiateSecMenu(Item);
                }
        }
    }
}