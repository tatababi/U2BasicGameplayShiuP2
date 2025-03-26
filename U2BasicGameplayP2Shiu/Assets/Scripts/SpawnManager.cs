using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (animalPrefabs.Length == 0)
        {
            Debug.LogWarning("Animal Prefabs array is empty. Please assign prefabs in the inspector.");
        }
        else
        {
            InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        }
    }

    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        // Check if there are any prefabs to spawn
        if (animalPrefabs.Length > 0)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Debug.Log($"Spawning animal at {spawnPos}");

            // Instantiate the selected prefab at the spawn position
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        else
        {
            Debug.LogWarning("No animals to spawn.");
        }
    }
}
