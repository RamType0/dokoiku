﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour
{
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f;
            if (GameObject.Find("CardManager").GetComponent<CardManager>().CardChoiceEvent(mousePos))
            {
                enabled = false;
            }
        }
    }
}

