
using TMPro;
using UnityEngine;

namespace Albatross
{
    public class AttackCommand : CommandItem
    {
        public bool isInteractable = false;
        public GameObject interactable; 

        public override void Fire()
        {
            if (!isInteractable)
            {
                if (Time.time >= Player.nextAttackTime)
                {
                    Player.GetComponent<PlayerMovementControls>().WalkState = WalkState.Attacking;
                    Player.transform.LookAt(PlayerCameraControls.Enemy);
                    Player.Attack();
                    Player.nextAttackTime = Time.time + 1f / Player.attackRate;
                }
            }
            else
            {
                Animator ani = interactable.GetComponentInChildren<Animator>();
                if (interactable.tag == "Treasure Chest")
                {
                    ani.SetBool("OpenChest", true);
                    DropPrize ChestPrize  = interactable.GetComponent<DropPrize>();
                    ChestPrize.CollectDrops(FindObjectOfType<PlayerInventory>());
                }
                else
                    Debug.Log("No interactable tag");
                
            }
        }

        private void FixedUpdate()
        {
            if (isInteractable)
                GetComponentInChildren<TextMeshProUGUI>().text = "Interact";
            else
                GetComponentInChildren<TextMeshProUGUI>().text = "Attack";
        }
    }
}