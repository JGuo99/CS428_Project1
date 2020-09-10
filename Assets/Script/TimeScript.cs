﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    
    public GameObject timeTextObject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 10f);  //Update Time every 10sec
    }

    // Update is called once per frame
    void UpdateTime()
    {
        timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("h:mm tt");
    }

}