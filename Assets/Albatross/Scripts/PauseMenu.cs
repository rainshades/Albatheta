using Albatross;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Albatross
{
    public class PauseMenu : MonoBehaviour
    {
        List<GameObject> Options = new List<GameObject>();
        GameObject CurrentButton = null;
        Player inputs = null;

        int buttonIndex = 0;

        private void Awake()
        {
            inputs = new Player();
            for (int i = 0; i < transform.childCount; i++)
            {
                Options.Add(transform.GetChild(i).gameObject);
            }

            inputs.CommandMenu.CommandMenuCycle.performed += ctx => buttonIndex += Mathf.RoundToInt(ctx.ReadValue<float>());
            inputs.CommandMenu.EnterCommand.performed += ctx => CurrentButton.GetComponent<Button>();
        }

        public void PartyClick()
        {

        }

        public void BagClick()
        {

        }

        public void DeckClick()
        {

        }

        public void SaveClick()
        {

        }

        public void LoadClick()
        {

        }

        public void MainMenuClick()
        {

        }

        private void OnEnable()
        {
            inputs.Enable();
        }

        private void OnDisable()
        {
            inputs.Disable();
        }
    }
}