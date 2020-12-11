using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Albatross
{
    public class AnimationController : MonoBehaviour
    {
        bool InCombat, Moving, Grounded;
        //triggers
        bool Attack, Cast;
        int Attack_Number;

        List<string> Animation; 

        Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

    }
}