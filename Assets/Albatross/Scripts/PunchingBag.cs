using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross {
    public class PunchingBag : CharacterMovementObject
    {
        protected override void Movement()
        {
            if(KnockbackCounter <= 0 && grounded)
            {
                velocity = Vector3.zero; 
            }
            else
            {
                KnockbackCounter -= Time.deltaTime;
            }
        }
    }
}