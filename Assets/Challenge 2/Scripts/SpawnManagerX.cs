﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Prefabs of each ball variation")]
    GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", Random.Range(3,6));
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0, 3)], spawnPos, ballPrefabs[0].transform.rotation);

        Invoke("SpawnRandomBall", Random.Range(3,6));
    }

}
