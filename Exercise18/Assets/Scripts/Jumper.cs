﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Jumps the game object to the mouse location
/// </summary>
public class Jumper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            transform.position = position;
        }
    }
}
