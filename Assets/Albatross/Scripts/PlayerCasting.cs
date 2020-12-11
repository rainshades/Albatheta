
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script creates casting and notice board interactivity
namespace Albatross
{
    public class PlayerCasting : MonoBehaviour
    {
        public static float DistanceFromTarget;
        public float ToTarget;

        void Update()
        {
            RaycastHit Hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
            {
                ToTarget = Hit.distance;
                DistanceFromTarget = ToTarget;
            }
        }
    }
}