namespace Albatross
{
    public class EnemyCombat : NPCCombat
    {
        public DropPrize loot;

        protected override void Kill()
        {
            DropPrize Loot = Instantiate(loot, transform);
            Loot.transform.parent = null;
            base.Kill();
        }
    }
}