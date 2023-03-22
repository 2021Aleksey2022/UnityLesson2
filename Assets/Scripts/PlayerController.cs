using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //���������� ����� ������ � ����������
    public float horizontalInput;
    //�������� ������������ ������
    public float speed = 10.0f;
    //�������� �� , ������ �� ����� ����� ����� 
    public float xRange = 10.0f;
    public float zRange = 1.5f;
    public float forwardInput;
    //������ �� �����, ������ �� �� ����� ������� ��������
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������������� �������, ���� ����� �� ��� ����� �� �� �������
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
        //�������� ������ �� ��� �
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  forwardInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //��������� ������ �� ������
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
