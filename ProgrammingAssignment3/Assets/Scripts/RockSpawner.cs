using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabRock;

    [SerializeField]
    Sprite rockSprite0;
    [SerializeField]
    Sprite rockSprite1;
    [SerializeField]
    Sprite rockSprite2;

    // Sprite control
    public Sprite[] rock_colors;
    private int rand;

    // Spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
    Timer spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        // check for time and rocks quantity to spawn
        if (spawnTimer.Finished && GameObject.FindGameObjectsWithTag("newRock").Length < 3)
        {
            SpawnRock();

            // change spawn timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    /// <summary>
    /// Spawns a new rock at a random location
    /// </summary>
    void SpawnRock()
    {
        // Create new rock
        Vector3 location = new Vector3(Screen.width / 2,
            Screen.height / 2,
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;

        // Generates a random sprite for the new rock
        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = rockSprite0;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = rockSprite1;
        }
        else
        {
            spriteRenderer.sprite = rockSprite2;
        }
    }
}
