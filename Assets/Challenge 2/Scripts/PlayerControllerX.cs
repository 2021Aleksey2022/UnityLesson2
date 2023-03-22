using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float startSpawnDog = 0.0f;
    private float intervalSpawnDog = 2.0f;
   
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if(Time.time > (intervalSpawnDog + startSpawnDog))
           {
               GameObject myGameObject = (GameObject)Instantiate(dogPrefab);
               myGameObject.transform.position = this.gameObject.transform.position;
               startSpawnDog = Time.time;
           }

        }
    }
}
