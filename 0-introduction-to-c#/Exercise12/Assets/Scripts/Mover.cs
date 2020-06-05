using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves a game object
/// </summary>
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 1;
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().
            AddForce(new Vector2(Random.Range(-500, 500),
                     Random.Range(-550, 500)));
    }
}
