using UnityEngine;

namespace Albatross
{
    public class AllyMovementController : NPCMovementObject
    {
        protected override void TargetSelection()
        {

            if (Target.tag == "Enemy")
            {
                ani.SetBool("In combat", true);
            }

            foreach (GameObject go in PossibleTargets)
            {
                if (go != null)
                {
                    if (go.transform.tag == "Enemy" && go.gameObject.activeSelf)
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
}