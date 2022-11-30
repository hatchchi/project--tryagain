using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamMeUp : MonoBehaviour
{
 
    Color c;
    Material mat;
    Color tempColor;
    //[SerailizeField] private Material emmisiveMaterial;
    //[SerializeField] private Renderer objectToChange;
    private float opacity;
    private float intensity;
    public bool fading;
    public GameObject beamContainer;
    

    void Start()
    {
         
        opacity = 0;
        intensity = 1;
        mat = GetComponent<Renderer>().material;
        mat.EnableKeyword("_EMISSION"); 
        tempColor = mat.color;

        fading = false;
        
        
    }

    
    
    void Update()
    {
        
        if ((opacity <= 1) && (fading == false))
        {

            //alpha
            //tempColor.a = opacity;
            //mat.color = tempColor;
                        
            //intensity
            mat.SetColor("_EmissionColor", tempColor * opacity);

            //timing
            opacity = opacity + (.5f * Time.deltaTime);

            //Debug.Log("GOING UP opactiy____" + opacity);

        }


        if ((opacity >= 0.999) && (fading == false))
        {
            fading = true;
            //Debug.Log("changed fading to true");
            Invoke("turnOffContainer", 1f);
        }

        if ((intensity >= 0) && (fading == true))
        {
        //intensity
        mat.SetColor("_EmissionColor", tempColor * intensity);

        //timing
         intensity = intensity - (0.8f * Time.deltaTime);

         //Debug.Log("GOING DOWN intensity____" + intensity);
            //Debug.Log("fading is___" + fading);
        }

        
    }

    void turnOffContainer()
    {
        beamContainer.SetActive(false);
    }
}
