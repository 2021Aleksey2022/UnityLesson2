using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Переменная ввода игрока с клавиатуры
    public float horizontalInput;
    //Скорость передвижения игрока
    public float speed = 10.0f;
    //Диапазон за , котрый не может выйти игрок 
    public float xRange = 10.0f;
    public float zRange = 1.5f;
    public float forwardInput;
    //Ссылка на пиццу, котрую мы мы будем кормить животных
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Устанавливаем границы, чтоб игрок не мог выйти за их пределы
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if(transform.position.z < -zRange) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.x > xRange && transform.position.z > zRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //Движение игрока по оси Х
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  forwardInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Запустите снаряд от игрока
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
