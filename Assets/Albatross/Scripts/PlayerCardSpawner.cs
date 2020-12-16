﻿using UnityEngine;

namespace Albatross
{
    public class PlayerCardSpawner : MonoBehaviour
    {
        public GameObject CardPrefab;

        GameObject[] Enemies;

        GameObject LastSpellCast; 

        public void SpawnNewCard(SpellSO equipment)
        {
            CardPrefab.GetComponent<SpellCardObject>().SetCard(equipment);
            if(PlayerCameraControls.Enemy != null)
                CardPrefab.GetComponent<SpellCardObject>().Target = PlayerCameraControls.Enemy.gameObject; 
            GameObject go = Instantiate(CardPrefab, transform);
            
            go.transform.SetParent(null);
            LastSpellCast = go; 
        }

        private void Update()
        {
            Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if (Enemies.Length > 0)
                transform.LookAt(Enemies[0].transform);
        }
    }
}