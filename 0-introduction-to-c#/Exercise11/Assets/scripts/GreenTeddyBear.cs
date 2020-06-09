﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 newScale = transform.localScale;
        newScale.x *= 3;
        newScale.y *= 3;
        transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newScale = new Vector2(Random.Range(1, 4), Random.Range(1, 4));
        transform.localScale = newScale;

        Vector2 newPosition = new Vector2(Random.Range(-5, 5), Random.Range(-2, 2));
        transform.position = newPosition;
    }
}