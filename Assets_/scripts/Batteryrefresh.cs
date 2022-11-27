using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batteryrefresh : MonoBehaviour
{

    public GameObject batteryOriginal;
    public bool dispenserArea;


    void Start()
    {

        dispenserArea = true;
        // GameObject batteryClone = Instantiate(batteryOriginal);

        //batteryClone.SetActive(true);

    }

    void Update()
    {

        

        if (dispenserArea == true)
            { 

            GameObject batteryClone = Instantiate(batteryOriginal);

            batteryClone.SetActive(true);

            dispenserArea = false;
        }
    }

}


