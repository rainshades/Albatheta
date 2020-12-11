using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

namespace Albatross
{

    public class CanvasManager : MonoBehaviour
    {
        public static CanvasManager Instance { get => FindObjectOfType<CanvasManager>(); }

        [SerializeField]
        Canvas GameOverCanvas = null;

        public Transform CombatPauseUI;
        public Transform NonCombatPauseUI;
        public Transform GameplayUI;


        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void GameOver()
        {
            GameOverCanvas.gameObject.SetActive(true);
        }

        private void Update()
        {
            //Removes the gameplay UI if the Game is Paused or if there is dialog on screen. 
            GameplayUI.gameObject.SetActive(!GameManager.Instance.IsPaused);

            GameplayUI.gameObject.SetActive(!GameManager.Instance.inDialog);
        }

        public void UISwap()
        {
            if (GameManager.Instance.inCombat)
            {
                CombatPauseUI.gameObject.SetActive(!CombatPauseUI.gameObject.activeSelf);
            }
            else
            {
                NonCombatPauseUI.gameObject.SetActive(!NonCombatPauseUI.gameObject.activeSelf);
            }
        }
    }
}