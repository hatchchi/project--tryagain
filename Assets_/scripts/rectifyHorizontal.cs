using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectifyHorizontal : MonoBehaviour
{
    public GameObject boardAssembled;
    public bool rectified;
    public Vector3 newRotation;

    // Start is called before the first frame update
    //void Start()
    //{


    //}

    // Update is called once per frame
    void Update()
    {
        if (boardAssembled.transform.eulerAngles.y >= 0)
        {
            transform.eulerAngles = newRotation;
            //or transform.localEulerAngles
            Debug.Log("the angle are  " + transform.eulerAngles);
            rectified = true;
        }
    }
}
