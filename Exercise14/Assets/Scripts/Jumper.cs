using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Make the game object jump
/// </summary>
public class Jumper : MonoBehaviour
{
    // Jump location support
    const float MinX = -4;
    const float MaxX = 4;
    const float MinY = -2;
    const float MaxY = 2;

    // Timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    // Update is called once per frame
    void Update()
    {
        // Update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
        }
        
    }
}
