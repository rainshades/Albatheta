using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class EnemyMovementController : NPCMovementObject
    {
        protected override void TargetSelection()
        {
            if (Target != null)
            {
                if (Target.tag == "Ally" || Target.tag == "Player")
                {
                    ani.SetBool("In combat", true);
                }
            }

            foreach (GameObject go in PossibleTargets)
            {
                if (go.transform.tag == "Ally")
                {
                    Target = go;
                }
                else if (go.transform.tag == "Player")
                {
                    Target = go;
                }
            }
        }
    }
}