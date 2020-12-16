namespace Albatross
{
    public class CourageMenu : SecondaryMenus
    {
        public void LoadMenu()
        {
            if (transform.childCount == 0)
            {
                foreach (CourageSO Ability in Inventory.CourageSkills)
                {
                    InstantiateSecMenu(Ability);
                }
            }
        }
    }
}