using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private float cooldown;
    [SerializeField] public EnemySpawn[] enemySpawns;
    private float timeToSpawn;
    private int curentSpawnIndex;
    private void Start()
    {
        curentSpawnIndex = 0;
    }
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            enemySpawns[curentSpawnIndex].SpawnEnemy();
            curentSpawnIndex++;
            if (curentSpawnIndex > enemySpawns.Length - 1 ) 
            {
                curentSpawnIndex = 0;
            }
            timeToSpawn = Time.time + cooldown;
        }
    }
    
}
