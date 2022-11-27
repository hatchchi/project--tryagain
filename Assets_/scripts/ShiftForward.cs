using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftForward : MonoBehaviour
{
    public GameObject selectedButtonCover;


    
    void Start()

    {
        transform.Translate(-1, 0, 0);
        //System.Threading.Thread.Sleep(5);
        

        //float ButtonPos = -727;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate (0,0,50*Time.deltaTime);
        // if (selectedAirboard.transform.position.y <= 3.61)
        // {
        
        //Debug.Log(transform.position);
        //transform.Translate(0, (-1 * Time.deltaTime / 2), 0);
        //transform.position = new Vector3(-2.44, -0.10, 6.55);

        //Debug.Log("current position is:____" + selectedAirboard.transform.position);
        //transform.position = new Vector3(-2.44, transform.position.y, transform.position.z);

    }

    //SetLocalPositionAndRotation
    //SetParent
    //transform.Translate



    // Move the object forward along its z axis 1 unit/second.
    //transform.Translate(Vector3.forward* Time.deltaTime);

    // Move the object upward in world space 1 unit/second.
    // transform.Translate(Vector3.up* Time.deltaTime, Space.World);

}