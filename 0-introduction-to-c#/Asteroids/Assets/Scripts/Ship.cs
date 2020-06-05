using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Manages the ship game object
/// </summary>
public class Ship : MonoBehaviour
{
    // Ship support
    const float ThrustForce = 5;
    const float RotateDegreesPerSecond = 150;
    float shipRadius;
    Rigidbody2D shipBody;
    Vector2 thrustDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        shipBody = GetComponent<Rigidbody2D>();
        shipRadius = GetComponent<CircleCollider2D>().radius;
    }

    void OnBecameInvisible()
    {
        Vector2 position = transform.position;
        if (position.x * shipRadius < ScreenUtils.ScreenLeft || position.x * shipRadius > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }
        if (position.y * shipRadius > ScreenUtils.ScreenTop || position.y * shipRadius < ScreenUtils.ScreenBottom)
        {
            position.y *= -1;
        }
        transform.position = position;
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            shipBody.AddForce(thrustDirection * ThrustForce, ForceMode2D.Force);
        }
    }

    void Update()
    {
        float rotationInput = Input.GetAxis("Rotate");
        if (rotationInput != 0)
        {
            float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
            }
            transform.Rotate(Vector3.forward, rotationAmount);

            Vector3 currentRotation = transform.eulerAngles;
            float rotationRadians = currentRotation.z * Mathf.Deg2Rad;
            thrustDirection = new Vector2(Mathf.Sin(-rotationRadians), Mathf.Cos(-rotationRadians));
        }
    }
}
