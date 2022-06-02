using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movementSpeed;// la preferida es = 0.1
    public float rotationSpeed;// la preferida es = 2
    public float jumpForce;// la preferida es = 2
    public int maxJumps;//la preefrida es = 4

    int hasJump;
    Rigidbody rb;

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
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

        //Rotacion:
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        //Saltar:
        //Link código Jero. https://github.com/jeronimosanchezperuga/Cubo-WASD-AddForce-Jump/blob/main/Assets/PlayerController.cs
        /*if (Input.GetKey(KeyCode.D) && hasJump == maxJumps)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) && hasJump == maxJumps)
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }


        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "ground")
            {
                hasJump = maxJumps;
            }
        }*/
    }
}
