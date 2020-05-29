using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Drives a game object around the screen
/// </summary>
public class Driver : MonoBehaviour
{
    // Movement support
    const float MoveUnitsPerSecond = 5;


    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            position.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        transform.position = position;
    }
}
