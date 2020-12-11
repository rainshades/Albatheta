using UnityEngine;
using TMPro;

namespace Albatross
{
    public class PlayerStatsUI : MonoBehaviour
    {

        public TextMeshProUGUI Health, Courage, Mana;

        PlayerCombatStats player = null;

        private void Update()
        {
            if(player == null)
            {
                player = GameManager.Instance.GetComponent<Party>().Player.GetComponent<PlayerCombatStats>();
            }

            if (!GameManager.Instance.IsPaused)
            {
                Health.text = "Health: " + player.Health;
                Courage.text = "Courage: " + player.Courage;
                Mana.text = "Mana: " + player.Mana;
            }
            else
            {
                Health.gameObject.SetActive(false);
                Courage.gameObject.SetActive(false);
                Mana.gameObject.SetActive(false);
            }
        }
    }
}