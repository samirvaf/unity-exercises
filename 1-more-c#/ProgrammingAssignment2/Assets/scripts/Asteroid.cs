using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An asteroid
/// </summary>
public class Asteroid : MonoBehaviour
{
    [SerializeField]
    Sprite asteroidSprite0;
    [SerializeField]
    Sprite asteroidSprite1;
    [SerializeField]
    Sprite asteroidSprite2;


    public void Initialize(Direction direction, Vector3 location)
    {
        float angle = Random.Range(0, 31);
        switch (direction)
        {
            case Direction.Up:
            {
                angle += 75;
                break;
            }
            case Direction.Down:
            {
                angle += 255;
                break;
            }
            case Direction.Left:
            {
                angle += 165;
                break;
            }
            case Direction.Right:
            {
                angle += 345;
                break;
            }
        }
        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;

        angle *= Mathf.Deg2Rad;
        Vector2 moveDirection = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            moveDirection * magnitude,
            ForceMode2D.Impulse);
        transform.position = location;
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
	{
        // set random sprite for asteroid
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber < 1)
        {
            spriteRenderer.sprite = asteroidSprite0;
        }
        else if (spriteNumber < 2)
        {
            spriteRenderer.sprite = asteroidSprite1;
        }
        else
        {
            spriteRenderer.sprite = asteroidSprite2;
        }
	}
}
