using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamUp : MonoBehaviour
{
    float appearing_speed = 2f;
    
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    
    void Update()
    {
        if (Time.time > 2)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.2f, 0.2f, 0.2f), appearing_speed * Time.deltaTime);
        }
            
    }
}

