using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovimiento : MonoBehaviour
{
    public float sube;
    public float alturaLimite;
    public bool subir = false;
    public bool cuboToca = false; 
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision tocando)
    {
        if (tocando.gameObject.name == "Cube")
        {
            cuboToca = true;
            subir = true;
            if (subir)
            {
                transform.Translate(sube, 0, 0);
            }
            if (transform.position.y == alturaLimite && cuboToca)
            {
                subir = false;

            }
        }
    }
        void Update()
    {
            
    }
    
    void OnCollisionExit(Collision sintocar)
        {
            if (sintocar.gameObject.name == "Cube")
            {
                cuboToca = false;
            }
        }





}
