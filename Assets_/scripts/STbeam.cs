using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STbeam : MonoBehaviour
{

    public GameObject beamedObject;
    public bool copied;

    // Start is called before the first frame update


    public virtual void DoCopy()
    {

        if (copied == false)
        {
            //example Instantiate(powerpack, new Vector3(0, 0, 0), Quaternion.identity);
            //Instantiate(beamedObject, transform.position, transform.position);

            copied = true;
            //Debug.Log("just turned copied to true");
        }
        else
        {
            //Debug.Log("tried copying but copied was set to true");
            copied = false;
        }
    }




}
