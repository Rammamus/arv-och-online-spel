using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    public Transform[] spawnPoints;
    int currPower;
    int curAmount;
    int maxAmount;
    int curSpawnPoint;
    float timer;
    private void Start()
    {
        maxAmount = spawnPoints.Length;
        curSpawnPoint = 0;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (curAmount < maxAmount && timer > 5)
        {
            Spawn();
        }
    }

    void Spawn()
    {

        print(currPower); //
        Instantiate(powerUps[currPower], spawnPoints[curSpawnPoint].transform.position, Quaternion.identity);
        curSpawnPoint++;
        if (curSpawnPoint > maxAmount)
        {
            curSpawnPoint = 0;
        }
        if (currPower == 0)
        {
            currPower++;
        }
        else
        {
            currPower--;
        }
        timer = 0;
        curAmount++;
    }
}
