using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject cuentaRegresiva;
    public GameObject cubito;

    public Text tiempoCount;

    int segundosContar;

    public float tiempoCambiar = 2;
    public float tiempoEspera = 2;
    void Start()
    {
        segundosContar = 3;
        tiempoCount.text = segundosContar.ToString();
    }

    public void Update()
    {
        while (tiempoCambiar < Time.time && segundosContar > 0)
        {
            segundosContar--;
            tiempoCount.text = segundosContar.ToString();
            tiempoCambiar += tiempoEspera;
            if (segundosContar == 0)
            {
                cuentaRegresiva.SetActive(!cuentaRegresiva.activeInHierarchy);
                cubito.SetActive(!cubito.activeInHierarchy);
            }
        }
    }
}
