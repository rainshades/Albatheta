using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Albatross
{
    public class SecondaryCommand : CommandItem
    {
        [SerializeField]
        Equipment equipment = null;

        public GameObject CardPrefab;
        public TextMeshProUGUI text;
        [SerializeField]
        PlayerCardSpawner PCS;

        Animator ani; 

        Player Controls;

        public Equipment Equipment { get => equipment; set => equipment = value; }

        private void Awake()
        {
            Player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterCombat>();
            PlayerCamera = FindObjectOfType<PlayerCameraControls>();
            image = GetComponentInChildren<RawImage>();
            Controls = new Player();
            PCS = FindObjectOfType<PlayerCardSpawner>();
            ani = Player.GetComponent<Animator>(); 
        }

        public override void Fire()
        {
            if (Equipment is SpellSO && Equipment.Cost <= Player.GetComponent<CharacterCombatStats>().Mana)
            {
                Player.Cast(Equipment as SpellSO);
                if (Equipment is QuickSpell || Equipment is SlowSpell)
                {
                    PCS.SpawnNewCard(equipment as SpellSO);

                    CommandMenu.Instance.NextAction();
                }

            }
            else if(equipment is Potions)
            {
                Potions item = equipment as Potions;
                item.Effect(item.Item_Effect_Value, Player.transform);
                foreach(EffectType effect in item.EquipmentEffects)
                {
                    effect.FireEffect(Player.combatStats);
                }
            }
            else if(equipment is CourageSO && Equipment.Cost <= Player.GetComponent<CharacterCombatStats>().Courage)
            {
                CourageSO ability = Equipment as CourageSO; 
                
                Player.Cast(ability);
               /* ability.Effect(ability.damage, Player.transform);
                foreach(EffectType effect in ability.EquipmentEffects)
                {
                    effect.FireEffect(Player.combatStats);
                }*/
                ani.Play(ability.AnimationName);
            }
        }

        public void NewCommand()
        {
            if (Equipment is SpellSO)
            {
                SpellCardObject CO = CardPrefab.GetComponentInChildren<SpellCardObject>();
                CO.SpellCard = Equipment as SpellSO;
                PCS.CardPrefab = CardPrefab;
            }

            text.text = Equipment.name;
        }


        private void OnEnable()
        {
            Controls.Enable();
        }

        private void OnDisable()
        {
            Controls.Disable();
        }

    }
}