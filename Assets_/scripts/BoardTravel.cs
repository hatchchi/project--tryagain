using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTravel : MonoBehaviour
{
    
    public GameObject selectedAirboard;
    

    // Start is called before the first frame update
    //void Start()
    //{
        
   // }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate (0,0,50*Time.deltaTime);
        if (selectedAirboard.transform.position.y <= 3.61)
            {
                transform.Translate(0, (1 * Time.deltaTime / 2), 0);
            }
        
        //Debug.Log("current position is:____" + selectedAirboard.transform.position);

        
    }

    //SetLocalPositionAndRotation
    //SetParent
    //transform.Translate

    
    
    // Move the object forward along its z axis 1 unit/second.
    //transform.Translate(Vector3.forward* Time.deltaTime);

    // Move the object upward in world space 1 unit/second.
    // transform.Translate(Vector3.up* Time.deltaTime, Space.World);

}
