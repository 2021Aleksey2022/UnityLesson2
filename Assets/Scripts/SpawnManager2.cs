using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefab2;
    private float spawnRange1X = -20;
    private float spawnRange2X = -19;
    private float spawnRange2Z = 15.0f;
    private float spawnPos1Z = 5.0f;
    private float startSpawnAnimal = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal2", startSpawnAnimal, Random.Range(2f, 4f));
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    void SpawnRandomAnimal2()
    {
        int animalIndex2 = Random.Range(0, animalPrefab2.Length);
        Vector3 spawnPos2 = new(Random.Range(spawnRange1X, spawnRange2X), 0, Random.Range(spawnPos1Z, spawnRange2Z));
        Instantiate(animalPrefab2[animalIndex2], spawnPos2, animalPrefab2[animalIndex2].transform.rotation);
    }
}
