using UnityEngine.SceneManagement;

namespace Albatross
{
    public class PlayerMovementData : CharacterMovementData
    {
        void OnEnable()
        {
            SceneManager.sceneLoaded += MovementDataLoad;
        }


        void MovementDataLoad(Scene scene, LoadSceneMode mode)
        {
            FindObjectOfType<Party>().PlayerStats.MovementDataSetup(this);
        }
    }
}

