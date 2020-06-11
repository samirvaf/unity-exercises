using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    Sprite asteroidSprite1;
    [SerializeField]
    Sprite asteroidSprite2;
    [SerializeField]
    Sprite asteroidSprite3;

    // Impulse helper
    const float minImpulse = 3f;
    const float maxImpulse = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Sprite[] sprites = { asteroidSprite1, asteroidSprite2, asteroidSprite3 };
        SpriteRenderer asteroidSprite = GetComponent<SpriteRenderer>();
        asteroidSprite.sprite = sprites[Random.Range(0, 3)];

        float angle = Random.Range(0, 2f * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulse, maxImpulse);
        Rigidbody2D asteroid = GetComponent<Rigidbody2D>();
        asteroid.AddForce(direction * magnitude, ForceMode2D.Impulse);
    }
}
