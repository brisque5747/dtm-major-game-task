using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject powerupPrefab;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float spawnIntervalObstacles = 2.5f;
    private float spawnRangeY = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
        InvokeRepeating("SpawnPowerups", startDelay, spawnIntervalObstacles);
    }
    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// This spawns obstacles through an array in different places
    /// </summary>
    void SpawnObstacles()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
    /// <summary>
    /// This spawns powerups much in the same way as the SpawnObstacles function
    /// </summary>
    void SpawnPowerups()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeY, spawnRangeY), 0, spawnPosZ);
        Instantiate(powerupPrefab, spawnPos, powerupPrefab.transform.rotation);
    }
}
