using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class ItemCommand : CommandItem
    {
        public override void Fire()
        {
            transform.GetComponentInParent<CommandMenu>().SwapToItemMenu();
        }
    }
}