using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollsions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroys the objects upon collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
