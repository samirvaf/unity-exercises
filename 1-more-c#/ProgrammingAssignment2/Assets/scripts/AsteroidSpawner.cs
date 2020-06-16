using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabAsteroid;

    float asteroidRadius;
    Asteroid direction;
    Vector3 location;

    // Start is called before the first frame update
    void Start()
    {
        // Store radius value
        GameObject asteroid = Instantiate(prefabAsteroid) as GameObject;
        asteroidRadius = asteroid.GetComponent<CircleCollider2D>().radius;
        Destroy(asteroid);

        // Spawn asteroid at the right side
        asteroid = Instantiate(prefabAsteroid) as GameObject;
        direction = asteroid.GetComponent<Asteroid>();
        location = asteroid.transform.position;
        location.y = 0;
        location.x = asteroidRadius + ScreenUtils.ScreenRight;
        direction.Initialize(Direction.Left, location);

        // Spawn asteroid at the left side
        asteroid = Instantiate(prefabAsteroid) as GameObject;
        direction = asteroid.GetComponent<Asteroid>();
        location = asteroid.transform.position;
        location.y = 0;
        location.x = asteroidRadius + ScreenUtils.ScreenLeft;
        direction.Initialize(Direction.Right, location);

        // Spawn asteroid at the top
        asteroid = Instantiate(prefabAsteroid) as GameObject;
        direction = asteroid.GetComponent<Asteroid>();
        location = asteroid.transform.position;
        location.y = asteroidRadius + ScreenUtils.ScreenTop;
        location.x = 0;
        direction.Initialize(Direction.Down, location);

        // Spawn asteroid at the bottom
        asteroid = Instantiate(prefabAsteroid) as GameObject;
        direction = asteroid.GetComponent<Asteroid>();
        location = asteroid.transform.position;
        location.y = asteroidRadius + ScreenUtils.ScreenBottom;
        location.x = 0;
        direction.Initialize(Direction.Up, location);
    }
}
