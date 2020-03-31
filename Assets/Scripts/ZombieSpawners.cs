using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawners : MonoBehaviour
{
    public GameObject enemy;
    float randomX, randomY;
    Vector2 spawnPoint;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    const int MAX_ENEMY = 30;

    void Update()
    {
        if(Time.time > nextSpawn && Enemy.numOfEnemies < MAX_ENEMY) {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-28f,27f);

            if(randomX  < -18f) randomY = 2.4f;
            else if(randomX < -9f && randomX >-16f) randomY = 6.1f;
            else if(randomX > -3f && randomX < 9f) randomY = 4.5f;
            else if(randomX > 14f && randomX < 20f) randomY = 4.5f;
            else randomY = 14.5f;            

            spawnPoint = new Vector2(randomX,randomY);
            Instantiate(enemy, spawnPoint, Quaternion.identity);
            Enemy.numOfEnemies++;
        }

    }
}
