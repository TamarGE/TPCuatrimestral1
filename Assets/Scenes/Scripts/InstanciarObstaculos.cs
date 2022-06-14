using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObstaculos : MonoBehaviour
{
    GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Caer()
    {
        for (int counter = 1; counter > 0; counter++)
        {
            clon = Instantiate(gameObject);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PlanoCaida")
        {
            Destroy(clon);
        }
    }
}
/*
 public GameObject objectToClone;
    public Text cloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        
        for (int counter = 0; counter < int.Parse(cloneAmount.text); counter++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 1); //destruír el clon después de un seg
        }
        

    }
     */
