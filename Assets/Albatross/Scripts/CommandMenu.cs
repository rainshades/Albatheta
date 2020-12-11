using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class CommandMenu : MonoBehaviour
    {
        [SerializeField]
        List<CommandItem> Actions = new List<CommandItem>();
        public CommandItem CurrentButton;

        public GameObject[] Menus;
        public GameObject CurrentMenu;

        int CommandIndex = 0;

        Player CommandMenuControls;

        public static CommandMenu Instance { get => FindObjectOfType<CommandMenu>(); }

        void Awake()
        {
            CommandMenuControls = new Player();

            for (int i = 0; i < Menus[0].transform.childCount; i++)
            {
                Actions.Add(Menus[0].transform.GetChild(i).GetComponent<CommandItem>());
            }

            CurrentMenu = Menus[0];

            CommandMenuControls.CommandMenu.CommandMenuCycle.performed += ctx => CommandIndex += Mathf.RoundToInt(ctx.ReadValue<float>());
            CommandMenuControls.CommandMenu.EnterCommand.performed += ctx => CurrentButton.Fire();
            CommandMenuControls.PlayerControls.Block.performed += Block_performed;
        }

        public void ActionHover(CommandItem Command)
        {
            if(Actions.Contains(Command)) CommandIndex = Actions.IndexOf(Command); 
        }

        private void Block_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (CurrentMenu != Menus[0])
            {
                foreach (CommandItem Action in Actions)
                {
                    Action.gameObject.SetActive(false);
                }
                Actions.Clear();
                CurrentMenu = Menus[0];
                for (int i = 0; i < Menus[0].transform.childCount; i++)
                {
                    Actions.Add(Menus[0].transform.GetChild(i).GetComponent<CommandItem>());
                }
                CommandIndex = 0;
            }
        }

        private void Update()
        {
            if (!GameManager.Instance.IsPaused)
            {
                if (CommandIndex > -1 && CommandIndex < Actions.Count)
                    CurrentButton = Actions[CommandIndex];

                else if (CommandIndex < 0)
                {
                    CommandIndex = 0;
                }
                else if (CommandIndex >= Actions.Count - 1)
                {
                    CommandIndex = Actions.Count - 1;
                }
            }
        }

        public void SwapToItemMenu()
        {
            Actions.Clear();
            CurrentMenu = Menus[2];
            Menus[2].SetActive(true);
            for (int i = 0; i < CurrentMenu.transform.childCount; i++)
            {
                CurrentMenu.transform.GetChild(i).gameObject.SetActive(true);
                Actions.Add(CurrentMenu.transform.GetChild(i).GetComponent<CommandItem>());
            }
            CommandIndex = 0;
        }

        public void SwapToSpellMenu()
        {
            Actions.Clear();
            CurrentMenu = Menus[1];
            Menus[1].SetActive(true);
            for (int i = 0; i < CurrentMenu.transform.childCount; i++)
            {
                CurrentMenu.transform.GetChild(i).gameObject.SetActive(true);
                Actions.Add(CurrentMenu.transform.GetChild(i).GetComponent<CommandItem>());
            }

            CommandIndex = 0;
        }

        public void SwapToCourageMenu()
        {
            Actions.Clear();
            CurrentMenu = Menus[3];
            Menus[3].SetActive(true);

            for (int i = 0; i < CurrentMenu.transform.childCount; i++)
            {
                CurrentMenu.transform.GetChild(i).gameObject.SetActive(true);
                Actions.Add(CurrentMenu.transform.GetChild(i).GetComponent<CommandItem>());
            }

            CommandIndex = 0;


        }

        public void NextAction()
        {
            if (Actions.Count > 1)
            {
                Destroy(Actions[CommandIndex].gameObject);
                Actions.RemoveAt(CommandIndex);
                CurrentButton = Actions[0];
            }
            else
            {
                CurrentMenu = Menus[0];
                for (int i = 0; i < Menus[0].transform.childCount; i++)
                {
                    Actions.Add(Menus[0].transform.GetChild(i).GetComponent<CommandItem>());
                }
                CurrentMenu = Menus[0];
            }
        }

        private void OnEnable()
        {
            CommandMenuControls.Enable();
        }

        private void OnDisable()
        {
            CommandMenuControls.Disable();
        }

    }
}