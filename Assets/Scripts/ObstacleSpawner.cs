using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject []obstacle;
    [SerializeField] Transform parent;

    float minX= -20f, maxX = -16f, minY = -2f, maxY = -7f;
    float timeBetweenSpawn = 3f;
    float spawnTime;
    int maxSpawns = 10;
    
    
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        

        if (parent.childCount < maxSpawns)
        {
            Instantiate(obstacle[Random.Range(0, obstacle.Length)], transform.position + new Vector3(randomX, randomY, 0), transform.rotation, parent);
        }

        
    }
}
