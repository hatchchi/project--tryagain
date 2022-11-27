using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetBoard;
    public Vector3 offset;
    public bool airTravel;

   

       


    // Update is called once per frame
    void Update()
    {

        //Vector3 boardPos = transform.position;

        //tilePos.y = 15;
        


        if (airTravel == true)
        {
            
            
           
            transform.position = targetBoard.position + offset;

            transform.rotation = targetBoard.transform.rotation;



        }
    }
}
