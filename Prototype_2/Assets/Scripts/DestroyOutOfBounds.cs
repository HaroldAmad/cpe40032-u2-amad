using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if - else statement to destroy objects out of camera
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Displays Game Over when animals reaches lower boundary
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
