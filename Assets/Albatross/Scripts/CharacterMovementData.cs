using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Albatross
{

    public class CharacterMovementData : MonoBehaviour
    {
        [SerializeField]
        float movement_speed, jump_height, gravity;

        public float Movement_speed { get => movement_speed; set => movement_speed = value; }
        public float Jump_height { get => jump_height; set => jump_height = value; }
        public float Gravity { get => gravity; set => gravity = value; }

    }
}

