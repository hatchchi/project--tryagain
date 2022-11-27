using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPClone : MonoBehaviour
{

    public GameObject powerpack;
    public bool copied;

    // Start is called before the first frame update
    
    
       public virtual void DoCopy()
        {

        if (copied == false)
        {
            //Instantiate(powerpack, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(powerpack, transform.position, transform.rotation);
           
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
