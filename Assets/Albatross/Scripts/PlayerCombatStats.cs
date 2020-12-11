using UnityEngine.SceneManagement;

namespace Albatross
{
    public class PlayerCombatStats : CharacterCombatStats
    {
        void Awake()
        {
            SceneManager.sceneLoaded += MovementDataLoad;
        }


        void MovementDataLoad(Scene scene, LoadSceneMode mode)
        {
            FindObjectOfType<Party>().PlayerStats.CombatStatsSetup(this);
        }
    }
}