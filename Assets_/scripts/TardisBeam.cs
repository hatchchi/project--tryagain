using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TardisBeam : MonoBehaviour
{

    public GameObject canObject;
    public bool copied;

    // Start is called before the first frame update


    public virtual void DoCopy()
    {

        if (copied == false)
        {
            //Instantiate(powerpack, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(canObject, transform.position, transform.rotation);

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
