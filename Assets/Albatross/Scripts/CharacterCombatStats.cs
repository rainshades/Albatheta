using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Albatross
{
    public class CharacterCombatStats : MonoBehaviour
    {
        [SerializeField]
        protected int level, maxHealth, maxMana, maxDrive;

        [SerializeField]
        protected int attack, defence, specialAttack, specialDefence;

        [SerializeField]
        protected int currentHealth, currentDrive, currentMana;

        public int Health { get => currentHealth; set => currentHealth = value; }
        public int Level { get => level; set => level = value; }
        public int Courage { get => currentDrive; set => currentDrive = value; }
        public int Mana { get => currentMana; set => currentMana = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Special { get => specialAttack; set => specialAttack = value; }
        public int SpecialDefence { get => specialDefence; set => specialDefence = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int MaxMana { get => maxMana; set => maxMana = value; }
        public int MaxCourage { get => maxDrive; set => maxDrive = value; }

        void Awake()
        {
            currentHealth = maxHealth;
            currentMana = maxMana;
            currentDrive = maxDrive; 
        }

    }
}