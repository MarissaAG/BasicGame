using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds1 : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    private float sideBound = 30;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Lives 3");
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Lives 2");
          Destroy(gameObject);
        }
        else if(transform.position.x > sideBound)
        {
            Debug.Log("Lives 1");
            Destroy(gameObject);
        }
        else if(transform.position.x < -sideBound)
        {
            Debug.Log("Lives 0");
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
