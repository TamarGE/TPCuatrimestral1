using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    Vector3 posicionInicio = new Vector3 (0, 2, 0);
    Vector3 rotacionInicio = new Vector3 (0, 0, 0); 
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlanoCaida")
        {
            //Destroy(gameObject);
            transform.position = posicionInicio;
        }
    }*/
    void OnCollisionExit(Collision col)
    {
        transform.position = posicionInicio;
    }
}
