using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Массив животных, котрые будут спауниться случайным образом
    public GameObject[] animalPrefabs;
    //Спаун по оси Х
    private float spawnRangeX = 20;
    //Спаун по оси Z
    private float spawnPosZ = 20;
    //Через какоу время начало игры , 2 сек
    private float startDelay = 2;
    //Интервал между спауном животных, 1.5 сек
    private float startInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        //Рандомное создание животных
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
