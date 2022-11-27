using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPipeUp : MonoBehaviour
{
    bool halfPipe;
    bool firstStage;
    bool thirdStage;
    bool lastStage;
    float currentAngle;
    float previousAngle;
    float currentHeight;
    float previousHeight;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 359);
        halfPipe = true;
        firstStage = true;
        thirdStage = false;
        lastStage = false;

        currentAngle = transform.rotation.eulerAngles.y;
        previousAngle = currentAngle;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (halfPipe == true)
        {
            if (firstStage == true)
            {
                
                //Rotate up half pipe
                if (currentAngle >= (previousAngle - 80))
                {
                    Debug.Log("________________________________FIRST STAGE");
                    transform.Rotate(0, 0, -60 * Time.deltaTime);
                    currentAngle = currentAngle - (60 * Time.deltaTime);
                    
                    if (currentAngle <= (previousAngle - 80))
                    {
                        previousHeight = transform.position.y;
                        currentHeight = previousHeight;
                    }
                }

                    //upward stage
                if (currentAngle <= (previousAngle - 80) && currentHeight >= (previousHeight -1))
                {
                    Debug.Log("_______________________________SECOND STAGE"); 
                    transform.Translate(-3 * Time.deltaTime, 0, 0);
                    currentHeight = currentHeight - (3 * Time.deltaTime);
                    
                    if (currentHeight <= (previousHeight - 1))
                    {
                        currentAngle = transform.rotation.eulerAngles.y;
                        previousAngle = currentAngle; 
                        firstStage = false;
                        thirdStage = true;
                        Debug.Log("________________________________________________________end of first stage");
                    }
                }
            }

            if (firstStage == false)
            {
                //TOP ROTATION  
                if (thirdStage == true)
                {
                    if (currentHeight <= (previousHeight - 1) && currentAngle >= (previousAngle - 180))
                    {
                        Debug.Log("_______________________________THIRD STAGE");
                        transform.Rotate(0, -400 * Time.deltaTime, 0);
                        currentAngle = currentAngle - (400 * Time.deltaTime);

                        if (currentAngle <= (previousAngle - 180))
                        {
                            previousHeight = transform.position.y;
                            currentHeight = previousHeight;
                            thirdStage = false;
                        }
                    }
                }

                // downward straight
                if (currentAngle <= (previousAngle - 180) && currentHeight >= (previousHeight - 1))
                {
                    Debug.Log("_______________________________FOURTH STAGE");
                    transform.Translate(-5 * Time.deltaTime, 0, 0);
                    currentHeight = currentHeight - (5 * Time.deltaTime);

                    if (currentHeight <= previousHeight - 1)
                    {
                        currentAngle = transform.rotation.eulerAngles.y;
                        previousAngle = currentAngle;
                        lastStage = true;
                    }
                }

                //Landing Curve

                if (lastStage == true)
                {
                    if (currentHeight <= (previousHeight - 1) && currentAngle >= (previousAngle - 80))
                    {
                        Debug.Log("_______________________________FIFTH STAGE");
                        transform.Rotate(0, 0, -60 * Time.deltaTime);
                        currentAngle = currentAngle - (60 * Time.deltaTime);


                        if (currentAngle <= (previousAngle - 80))
                        {
                            halfPipe = false;
                            firstStage = true;
                            lastStage = false;
                            Debug.Log("________________________________________________________end of second set");
                        }

                    }
                }
            }
        }

            

        
    }
}

