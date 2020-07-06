using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int health = 100;
    const float minImpulseForce = 3f;
    const float maxImpulseForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 361) * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        health -= 10;
        Debug.Log($"Current health: #{health}");
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
