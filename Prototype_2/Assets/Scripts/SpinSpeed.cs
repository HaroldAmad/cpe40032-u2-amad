using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    private float spinSpeed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinSpeed, 0);
    }
}
