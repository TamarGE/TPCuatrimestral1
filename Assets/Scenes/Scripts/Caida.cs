﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{
    Vector3 posicionInicio;
    //Vector3 rotacionInicio = new Vector3 (0, 0, 0); 
    void Start()
    {
        posicionInicio = transform.position;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlanoCaida" || col.gameObject.name == "obstaculo")
        {
            //Destroy(gameObject);
            transform.position = posicionInicio;
        }
    }
    /*void OnCollisionExit(Collision col)
    {
        transform.position = posicionInicio;
    }*/
}
