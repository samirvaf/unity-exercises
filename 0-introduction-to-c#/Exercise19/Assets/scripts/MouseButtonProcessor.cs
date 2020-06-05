using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                Instantiate(prefabTeddyBear, position, Quaternion.identity);

            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
		if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            GameObject teddyBear = GameObject.FindWithTag("TeddyBear");

            if (!explodeInputOnPreviousFrame && teddyBear != null)
            {
                explodeInputOnPreviousFrame = true;
                Vector3 position = teddyBear.transform.position;
                Destroy(teddyBear);
                Instantiate(prefabExplosion, position, Quaternion.identity);
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
	}
}
