﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private float xRotate;
    private float yRotate;
    private Quaternion cameraVector;

    void FixedUpdate()
    {
        cameraVector = Quaternion.Euler(0, xRotate, 0);
        GameObject.Find("Player").transform.rotation = cameraVector;
        xRotate += Input.GetAxis("Mouse X");
        yRotate += Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(yRotate, xRotate, 0);
    }
}
