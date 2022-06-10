using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PruebaTiempo : MonoBehaviour
{
    public Text tiempoNormal;
    public Text tiempoSeg;
    public Text tiempoCount;

    int segundosContar;

    public float tiempoCambiar;
    public float tiempoEspera;
    void Start()
    {
        segundosContar = 3;
        tiempoCount.text = segundosContar.ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        tiempoNormal.text = Time.time.ToString();
        tiempoSeg.text = Mathf.FloorToInt(Time.time).ToString();
        while (tiempoCambiar < Time.time && segundosContar > 0)
        {
            segundosContar--;
            tiempoCount.text = segundosContar.ToString();
            tiempoCambiar += tiempoEspera;
        }
        /*for (tiempoCambiar = 2; tiempoCambiar < Time.time; tiempoCambiar += tiempoEspera)
        {
            segundosContar--;
            tiempoCount.text = segundosContar.ToString();
        }*/
    }
}
