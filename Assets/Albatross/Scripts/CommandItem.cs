using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Albatross
{
    public abstract class CommandItem : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
    {
        [SerializeField]
        protected CharacterCombat Player;
        public abstract void Fire();

        public Color SelectColor, NormalColor;
        public PlayerCameraControls PlayerCamera;
        protected RawImage image;

        private void Awake()
        {
            Player = FindObjectOfType<PlayerMovementControls>().GetComponent<CharacterCombat>();

            PlayerCamera = FindObjectOfType<PlayerCameraControls>();
            image = GetComponent<RawImage>();
        }
        private void Update()
        {
            if(Player == null)
            {
                Player = FindObjectOfType<PlayerMovementControls>().GetComponent<CharacterCombat>();
            }

            if(PlayerCamera == null)
            {
                PlayerCamera = FindObjectOfType<PlayerCameraControls>();
            }

            if (this == CommandMenu.Instance.CurrentButton)
            {
                image.color = SelectColor;
            }
            else
            {
                image.color = NormalColor;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Fire();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            CommandMenu.Instance.ActionHover(this);
        }
    }
}