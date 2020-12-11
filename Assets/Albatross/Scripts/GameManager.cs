using UnityEngine;
using Fungus; 

namespace Albatross
{
    public class GameManager : MonoBehaviour
    {
        Player Controls;

        bool paused = false;
        
        public bool inDialog = false; 

        public bool inCombat;

        static GameManager _instance; 

        public bool IsPaused { get => paused; }
        public static GameManager Instance { 
            get
            {
                return FindObjectOfType<GameManager>(); 
            } 
            set {
                _instance = FindObjectOfType<GameManager>();
                if (_instance != null)
                {
                    Destroy(_instance); 
                }
            }
        }


        public void Pause()
        {
            paused = true; 
        }

        void Awake()
        {
            Controls = new Player();

            Controls.PlayerControls.Pause.performed += Pause_performed;

            CanvasManager.Instance.CombatPauseUI.gameObject.SetActive(false);
            DontDestroyOnLoad(this);
        }

        void Update()
        {
            Flowchart flowchart = FindObjectOfType<Flowchart>();

            if(flowchart != null)
            {
                inDialog = flowchart.GetBooleanVariable("InDialog");
            }

            if (paused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }


        private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            paused = !paused;

            CanvasManager.Instance.UISwap();
        }

        private void OnDisable()
        {
            Controls.Disable();
        }

        private void OnEnable()
        {
            Controls.Enable();
        }
    }
}