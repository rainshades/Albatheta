using UnityEngine;

namespace Albatross
{
    [CreateAssetMenu(fileName = "new Potion", menuName = "Potion")]
    public class Potions : ItemSO
    {
        public bool full;

        [SerializeField]
        float max_restore_value = 0; 
        [SerializeField]
        float resevoir = 0;

        public float Item_Effect_Value { get => max_restore_value; }
        public float Resevoir { get => resevoir; }

        void Awake()
        {
            full = isFull(); 
        }

        bool isFull()
        {
            return resevoir == max_restore_value; 
        }

        public void FillResoir(int fillAmount)
        {
            if (!full)
            {
                if(resevoir + fillAmount < max_restore_value)
                    resevoir += fillAmount;
                else
                {
                    resevoir = max_restore_value; 
                }

                full = isFull();
            }
        }

        void UseResevoir()
        {
            resevoir = 0;
            full = isFull(); 
        }

        public override void Effect(float value, Transform caster)
        {
            base.Effect(value, caster);
            UseResevoir();
        }

    }
}