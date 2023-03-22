using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Скорость движения пиццы
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Движение пиццы по оси Z
       transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
