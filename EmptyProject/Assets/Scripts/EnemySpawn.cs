using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
   {
    private float timeToSpawn;
    [SerializeField] private float cooldown;
    [SerializeField] GameObject SpawnPoint;
    [SerializeField] GameObject Enemy;
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            GameObject EnemyInstance = Instantiate(Enemy);
            EnemyInstance.transform.position = SpawnPoint.transform.position;
            timeToSpawn = Time.time + cooldown;
        }
    }
}

