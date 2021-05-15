using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    public float spawnRangeX = 20f;
    public float spawnZ = 20f;
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int i = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[i];

        float x = Random.Range(-spawnRangeX, spawnRangeX);
            
        Instantiate(animal, new Vector3(x, 0, spawnZ), animal.transform.rotation);
    }
}
