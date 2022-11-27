using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public bool flyUp;
    public bool flyDown;
    public float flySpeed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (flyUp == true)
        {
            flySpeed = 1;
        }
        else
        {
            flySpeed = -1;
        }
        transform.Translate(0, (flySpeed * Time.deltaTime / 2), 0);
    }
}
