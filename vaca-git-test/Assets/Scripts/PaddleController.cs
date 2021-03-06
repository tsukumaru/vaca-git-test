﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float accel = 1000;

    private void Update()
    {
        var force = transform.right * Input.GetAxisRaw("Horizontal") * accel;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
    }
}