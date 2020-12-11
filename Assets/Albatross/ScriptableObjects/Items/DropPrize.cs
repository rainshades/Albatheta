using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Albatross
{
    public class DropPrize : MonoBehaviour
    {
        [SerializeField]
        List<Drops> item = new List<Drops>();
        [SerializeField]
        int count = 0; 

        public List<Drops> Item { get => item; }
        public int NumberOfItem { get => count; }

        //What Kind of Drop
        //Health, mana, drive restore go to that item's reservoir 
        //Inventory Items to to the inventory list and each inventory item needs to keep track of how many of each item there are 

        void Collect(List<Drops> Inventory, Drops item)
        {
            Inventory.Add(item);
        }

        void Fill_Resevoir(Potions Potion)
        {
            Potion.FillResoir(count); 
        }

        public void CollectDrops(PlayerInventory inventory)
        {
            foreach(Drops item in item)
            {
                if (item.RestoreDrop)
                {
                    switch (item.TypesofEffects[0])
                    {
                        case TypeOfEffect.Heal:
                            inventory.Potions[0].FillResoir(count);
                            break;
                        case TypeOfEffect.CourageRestore:
                            inventory.Potions[1].FillResoir(count);
                            break;
                        case TypeOfEffect.ManaRestore:
                            inventory.Potions[2].FillResoir(count);
                            break;
                        default:
                            Debug.LogError("Invalid Restore Attribute ");
                            break;
                    }
                }
                else
                {
                    Collect(inventory.NormalItems, item);
                }
            }
        }
    }
}