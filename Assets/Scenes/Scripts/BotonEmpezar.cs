﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonEmpezar : MonoBehaviour
{
    public GameObject myObject;
    public bool seVe = false;
    public void Ver()
    {
        if (seVe == false)
        {
            myObject.SetActive(!myObject.activeInHierarchy);
            seVe = true;
        }
    }
}
