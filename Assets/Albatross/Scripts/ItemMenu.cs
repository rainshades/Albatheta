namespace Albatross
{
    public class ItemMenu : SecondaryMenus
    {
        public void LoadMenu()
        {
            if (transform.childCount == 0)
                foreach (ItemSO Item in Inventory.Potions)
                {
                    InstantiateSecMenu(Item);
                }
        }
    }
}