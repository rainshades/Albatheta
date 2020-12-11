using UnityEngine;
using UnityEngine.SceneManagement;

namespace Albatross {
    public class InteractionController : MonoBehaviour
    {
        [SerializeField]
        AttackCommand Command;


        private void Awake()
        {
            Command = FindObjectOfType<AttackCommand>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Treasure Chest")
            {
                Command.isInteractable = true;
                Command.interactable = other.gameObject; 
            }

            if (other.tag == "CombatTrigger" && !other.GetComponent<CombatInstance>().Defeated)
            {
                foreach (GameObject E in other.GetComponent<CombatInstance>().Enemies)
                {
                    if(E != null)
                        E.SetActive(true);
                }
                GameManager.Instance.inCombat = true;
            }

            if (other.tag == "Door")
            {
                GameManager.Instance.GetComponent<Party>().PlayerStats.Set(GetComponent<PlayerCombatStats>(), GetComponent<CharacterMovementData>());
                SceneManager.LoadScene(other.gameObject.GetComponent<DoorToNewScene>().LevelToLoad);
            }

            if(other.tag == "Prize")
            {
                other.GetComponent<DropPrize>().CollectDrops(FindObjectOfType<PlayerInventory>());
                Destroy(other.gameObject);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Treasure Chest")
            {
                Command.interactable = null; 
                Command.isInteractable = false;
            }

            if (other.tag == "CombatTrigger" && !other.GetComponent<CombatInstance>().Defeated)
            {
                foreach (GameObject E in other.GetComponent<CombatInstance>().Enemies)
                {
                    if(E != null)
                        E.SetActive(false);
                }
                GameManager.Instance.inCombat = false;
            }

        }
    }
}