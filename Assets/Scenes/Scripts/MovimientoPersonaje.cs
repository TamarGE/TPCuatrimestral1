using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movementSpeed;// la preferida es = 0.1
    public float rotationSpeed;// la preferida es = 2

    public float jumpForce;// la preferida es = 2
    public int maxJumps;//la preefrida es = 4

    public float speed = 10f;
    Rigidbody rb;
    public bool cubeEnElPiso = true;

    //sonido:
    public AudioClip sonidoSalto;
    public AudioClip sonidoSlide;
    AudioSource fuenteSonidoSaltar;
    AudioSource fuenteSonidoSlide;

    /*
    public float rotacion; // con esto estoy probando si puedop lograr que el personaje
    public bool rotacionMenorA90 = true;// solo pueda rotar menos de 70 grados.
    */
    void Start()
    {
        //hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
        fuenteSonidoSaltar = GetComponent<AudioSource>();
        fuenteSonidoSlide = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento:
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(0, 0, movementSpeed);
            transform.Translate(0, 0, movementSpeed);
            if (cubeEnElPiso)
            {
                fuenteSonidoSlide.clip = sonidoSlide;
                fuenteSonidoSlide.Play();
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -movementSpeed);
            if (cubeEnElPiso)
            {
                fuenteSonidoSlide.clip = sonidoSlide;
                fuenteSonidoSlide.Play();
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
            if (cubeEnElPiso)
            {
                fuenteSonidoSlide.clip = sonidoSlide;
                fuenteSonidoSlide.Play();
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
            if (cubeEnElPiso)
            {
                fuenteSonidoSlide.clip = sonidoSlide;
                fuenteSonidoSlide.Play();
            }
        }

        //Rotacion:
        //decidí no agregar rotación como variable
/*
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }*/


        //Saltar:
        if (Input.GetKey(KeyCode.Space) && cubeEnElPiso)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            cubeEnElPiso = false;
            fuenteSonidoSaltar.clip = sonidoSalto;
            fuenteSonidoSaltar.Play();

        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Piso" || col.gameObject.name == "Plataforma")
        {
            cubeEnElPiso = true;
        }
    }
    }
