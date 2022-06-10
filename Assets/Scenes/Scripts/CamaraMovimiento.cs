using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;

    void Start()
    {

    }

    void Update()
    {
        //Movimiento:
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0, 0, movementSpeed);
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
    }
}
