﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEscenario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0.5f, 0));
    }
}
