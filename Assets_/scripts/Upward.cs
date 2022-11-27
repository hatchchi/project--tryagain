using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upward : MonoBehaviour
{
    
    public GameObject selectedAirboard;

    public GameObject loungeTimeline;

     

  
    void Update()  //add if statements here acting like subroutines for four commands (up, down, rotate left & right) each can be called up by trigger
    {
     //up
            transform.Translate(0, (1 * Time.deltaTime / 2), 0);
          
        //if (selectedAirboard.transform.position.y >= 2.0)
         //   {
         //       loungeTimeline.SetActive(true);
         //   }
        //Debug.Log("current position is:____" + selectedAirboard.transform.position);
        
    }

    /*
     call it with StartCouritne(Routine());

     public IEnumerator Routine()
      {
          while(true)
          {
              //Do stuff.
              yield return null;
          }
      }
 */

}
