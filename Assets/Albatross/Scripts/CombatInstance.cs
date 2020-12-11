using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class CombatInstance : MonoBehaviour
    {
        [SerializeField]
        List<GameObject> enemies = null;

        [SerializeField]
        bool defeated;

        public List<GameObject> Enemies { get => enemies; }

        public bool Defeated { get => defeated; }
        float InstanceRadius;


        private void Awake()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Enemies.Add(transform.GetChild(i).gameObject);
            }
        }

        private void Update()
        {
            if (transform.childCount == 0)
            {
                defeated = true;
                GameManager.Instance.inCombat = false; 
                Destroy(gameObject);
            }
        }
    }
}