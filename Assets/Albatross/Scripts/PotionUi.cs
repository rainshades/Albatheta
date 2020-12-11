using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Albatross
{
    public class PotionUi : MonoBehaviour
    {
        [SerializeField]
        int potionPosition = 0; 

        Image PotionUIImage;

        Potions CurrentFlask;

        float PercentFull = 0;

        private void Awake()
        {
            PotionUIImage = GetComponent<Image>();
            CurrentFlask = FindObjectOfType<PlayerInventory>().Potions[potionPosition];
        }

        private void Update()
        {
            PercentFull = CurrentFlask.Resevoir / CurrentFlask.Item_Effect_Value;
            PotionUIImage.color = new Color(PotionUIImage.color.r, PotionUIImage.color.g, PotionUIImage.color.b, PercentFull); 
        }
    }
}