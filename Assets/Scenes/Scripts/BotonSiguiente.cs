using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSiguiente : MonoBehaviour
{
    public GameObject textoInicial;
    public GameObject Instrucciones;
    public GameObject botonEmpezar;
    public bool seVe = true;
    public void Ver()
    {
        if (seVe)
        {
            textoInicial.SetActive(!textoInicial.activeInHierarchy);
            Instrucciones.SetActive(!Instrucciones.activeInHierarchy);
            botonEmpezar.SetActive(!botonEmpezar.activeInHierarchy);
            seVe = false;
        }
    }
}
