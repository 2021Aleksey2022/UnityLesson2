using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Граница для снаряда 
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Если снаряд залетает за эту границу, он будет удалён
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over!");
            Destroy(gameObject); 
        }
    }
}
