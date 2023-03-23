using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //randomly generate animal idx and spawn position
            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 
                0, spawnPosZ);
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
            // Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
            //    animalPrefabs[animalIndex].transform.rotation);

            Instantiate(animalPrefabs[animalIndex], spawnPos,
                animalPrefabs[animalIndex].transform.rotation);
        }
    }

    void SpawnRandomAnimal()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-xSpawnRange, xSpawnRange),
                0, spawnPosZ);
            int animalIndex = UnityEngine.Random.Range(0, anialPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex],
                new Vector3(0, 0, 20) spawnpos,
                animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
