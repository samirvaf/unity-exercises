using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Resizes the Yellow Bear
/// </summary>
public class YellowTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 3;
        //  quadruple  width  and  height
        Vector3 newScale = transform.localScale;
        newScale.x *= 4;
        newScale.y *= 4;
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
