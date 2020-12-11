using UnityEngine;

namespace Albatross
{
    [System.Serializable]
    public class PersistentStats
    {
        float movement_speed, jump_height, gravity;
        int level, maxHealth, maxMana, maxDrive, attack,
            defence, specialAttack, specialDefence,
            currentHealth, currentDrive, currentMana;

        public void CombatStatsSetup(CharacterCombatStats combatStats)
        {
            combatStats.Level = level;
            combatStats.MaxHealth = maxHealth;
            combatStats.MaxMana = maxMana;
            combatStats.MaxCourage = maxDrive;
            combatStats.Attack = attack;
            combatStats.Defence = defence;
            combatStats.Special = specialAttack;
            combatStats.SpecialDefence = specialDefence;
            combatStats.Health = currentHealth;
            combatStats.Courage = currentDrive;
            combatStats.Mana = currentMana; 
        }

        public void MovementDataSetup(CharacterMovementData MovementData)
        {
            MovementData.Gravity = gravity;
            MovementData.Jump_height = jump_height;
            MovementData.Movement_speed = movement_speed; 
        }

        public void Set(CharacterCombatStats combatStats, CharacterMovementData MovementData)
        {
            level = combatStats.Level;
            maxHealth = combatStats.MaxHealth;
            maxMana = combatStats.MaxMana;
            maxDrive = combatStats.MaxCourage;
            attack = combatStats.Attack;
            defence = combatStats.Defence;
            specialAttack = combatStats.Special;
            specialDefence = combatStats.SpecialDefence;
            currentHealth = combatStats.Health;
            currentDrive = combatStats.Courage;
            currentMana = combatStats.Mana;


            gravity = MovementData.Gravity;
            jump_height = MovementData.Jump_height;
            movement_speed = MovementData.Movement_speed;
        }

        public void SaveToFile(string FileName)
        {
            
            /*
                    public float movement_speed, jump_height, gravity;
        public int level, maxHealth, maxMana, maxDrive, attack,
            defence, specialAttack, specialDefence,
            currentHealth, currentDrive, currentMana;
            */
        }

        public void LoadToFile(string FileName)
        {

        }
    }
}