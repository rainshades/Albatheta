namespace Albatross
{
    public class SpellMenu : SecondaryMenus
    {
        private void Awake()
        {
            if (transform.childCount == 0)
                foreach (SpellSO Spell in Inventory.Spells)
                {
                    InstantiateSecMenu(Spell);
                }
        }
    }
}