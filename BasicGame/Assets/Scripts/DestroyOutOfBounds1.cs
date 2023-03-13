using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds1 : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
          Destroy(gameObject);
        }
    }
}
