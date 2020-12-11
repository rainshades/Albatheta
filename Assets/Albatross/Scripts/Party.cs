using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

namespace Albatross
{
    public class Party : MonoBehaviour
    {
        public GameObject Player; 
        public GameObject PartyMemberOne;
        public GameObject PartyMemberTwo;

        public PersistentStats PlayerStats;
        public PersistentStats MemberOneStats;
        public PersistentStats MemberTwoStats; 

        [SerializeField]
        List<GameObject> PartyWeapons = null; 

        void Awake()
        {
            PlayerStats.Set(Player.GetComponent<CharacterCombatStats>(), Player.GetComponent<CharacterMovementData>());
            SceneManager.sceneLoaded += OnLoadScene;
        }

        void Update()
        {
            if (GameManager.Instance.inCombat)
            {
                foreach(GameObject weapon in PartyWeapons)
                {
                    weapon.SetActive(true); 
                }
            }
        }        

        void OnLoadScene(Scene scene, LoadSceneMode mode)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
        }
    }
}