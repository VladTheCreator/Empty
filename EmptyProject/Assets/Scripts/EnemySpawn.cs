using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
   {
    [SerializeField] GameObject SpawnPoint;
    [SerializeField] GameObject Enemy;
        public void SpawnEnemy()
        {
                GameObject EnemyInstance = Instantiate(Enemy);
                EnemyInstance.transform.position = SpawnPoint.transform.position;
        }
   }


