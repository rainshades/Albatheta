
using TMPro;
using UnityEngine;

namespace Albatross
{
    public class EnemyUIHealthCheck : MonoBehaviour
    {
        public GameObject LastEnemyAttacked;

        [SerializeField]
        TextMeshProUGUI EnemyHealthText = null;
        int health;

        static EnemyUIHealthCheck instance;

        public static EnemyUIHealthCheck Instance { get => instance;  }

        private void Awake()
        {
            instance = FindObjectOfType<EnemyUIHealthCheck>();
        }
        // Update is called once per frame
        void Update()
        {

            if (LastEnemyAttacked != null)
            {

                EnemyHealthText.gameObject.SetActive(true);

                if (LastEnemyAttacked.GetComponent<CharacterCombatStats>() != null && LastEnemyAttacked.GetComponentInChildren<CharacterCombatStats>().Health > 0)
                {
                    health = LastEnemyAttacked.GetComponent<CharacterCombatStats>().Health;
                    EnemyHealthText.text = "HP: " + health;

                }
                else if (LastEnemyAttacked.GetComponentInChildren<CharacterCombatStats>() != null && LastEnemyAttacked.GetComponentInChildren<CharacterCombatStats>().Health > 0)
                {
                    health = LastEnemyAttacked.GetComponentInChildren<CharacterCombatStats>().Health;
                    EnemyHealthText.text = "HP: " + health;
                }

            }
            else
            {
                EnemyHealthText.gameObject.SetActive(false);
            }
        }
    }
}