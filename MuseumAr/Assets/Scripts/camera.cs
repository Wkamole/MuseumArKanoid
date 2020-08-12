﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float rotationX = 0;
    float rotationY = 0;
    float xRotTemp;
    float yRotTemp;

    void Start()
    {
        this.transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                FirstPoint = Input.GetTouch(0).position;
                xRotTemp = rotationX;
                yRotTemp = rotationY;
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                SecondPoint = Input.GetTouch(0).position;
                rotationX = xRotTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
                rotationY = yRotTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
                this.transform.rotation = Quaternion.Euler(rotationY, rotationX, 0.0f);
            }
        }

    }
}