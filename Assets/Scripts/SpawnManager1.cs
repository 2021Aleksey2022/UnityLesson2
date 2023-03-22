using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager1 : MonoBehaviour
{
    public GameObject[] animalPrefab1;
    private float spawnRange1X = 20;
    private float spawnRange2X = 21;
    private float spawnRange2Z = 14.0f;
    private float spawnPos1Z = 3.0f;
    private float startSpawnAnimal = 1.0f;
    //private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal1", startSpawnAnimal, Random.Range(3f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal1()
    {
        int animalIndex1 = Random.Range(0, animalPrefab1.Length);
        Vector3 spawnPos1 = new(Random.Range(spawnRange2X, spawnRange1X), 0, Random.Range(spawnPos1Z, spawnRange2Z));
        Instantiate(animalPrefab1[animalIndex1], spawnPos1, animalPrefab1[animalIndex1].transform.rotation);
    }
}
