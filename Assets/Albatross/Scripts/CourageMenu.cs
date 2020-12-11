namespace Albatross
{
    public class CourageMenu : SecondaryMenus
    {
        private void Awake()
        {
            if(transform.childCount == 0)
            {
                foreach(CourageSO Ability in Inventory.CourageSkills)
                {
                    InstantiateSecMenu(Ability);
                }
            }
        }
    }
}