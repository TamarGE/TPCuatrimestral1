using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonEmpezar : MonoBehaviour
{
    public GameObject botonEmpezar;
    public GameObject Instrucciones;
    public GameObject cuentaRegresiva;

    public bool seVe = false;

    public float tiempoCambiar;
    public float tiempoEspera;
    void Start()
    {

    }

    void Update()
    {

    }
        public void Ver()
    {
        if (seVe == false)
        {
            Instrucciones.SetActive(!Instrucciones.activeInHierarchy);
            botonEmpezar.SetActive(!botonEmpezar.activeInHierarchy);
            cuentaRegresiva.SetActive(!cuentaRegresiva.activeInHierarchy);
            seVe = true;
            
        }
    }
}

