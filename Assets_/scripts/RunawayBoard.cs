using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunawayBoard : MonoBehaviour
{
    float currentJourney;
    float currentAngle;
    float currentXValue;

    // Start is called before the first frame update
    void Start()
    {
        currentJourney = 0;
        currentAngle = 0;
        currentXValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentJourney <= 25)
        {
            
            transform.Translate(0, 0, -3 * Time.deltaTime);
            currentJourney = currentJourney + (3 * Time.deltaTime);
        }
        
        if ((currentJourney >= 19.99) && (currentAngle <= 91))
        {
            transform.Rotate(0, 60 * Time.deltaTime, 0);
            currentAngle = currentAngle + (60 * Time.deltaTime);
        }
        
        if ((currentAngle >= 90) && (currentXValue <= 55))
                {
            transform.Translate (0, 0, -3 * Time.deltaTime);
            currentXValue = currentXValue + (3 * Time.deltaTime);
        }

    }
}
