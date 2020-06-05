using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Resizes the game object
/// </summary>
public class Resizer : MonoBehaviour
{
    // Timer support
    const float TotalResizeSeconds = 3;
    float elapsedResizeSeconds = 0;

    // Resizing control
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            Vector2 newScale = transform.localScale;
            newScale.x += ScaleFactorPerSecond * scaleFactorSignMultiplier;
            newScale.y += ScaleFactorPerSecond * scaleFactorSignMultiplier;
            transform.localScale = newScale;
            scaleFactorSignMultiplier *= -1;
            elapsedResizeSeconds = 0;
        }
    }
}
