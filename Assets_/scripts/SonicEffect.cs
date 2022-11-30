using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicEffect : MonoBehaviour
{
 float opacity;
 Color c;
    Material mat;
    Color tempColor;
    private Material[] allMaterials;
    List<Color> allColors = new List<Color>();

    public Light myLight;

    void Start()
    {
        
        opacity = 0;
        
        mat = GetComponent<Renderer>().material;
        tempColor = mat.color;

        allMaterials = GetComponent<Renderer>().materials;
        for (int i = 0; i < allMaterials.Length; i++)
            allColors.Add(allMaterials[i].color);

        

        //myLight = GetComponent<Light>();
    }

    
    void Update()
    {
        
        if (opacity <= 1)
        {
            
            foreach (Material mat in allMaterials)
            {
                tempColor.a = opacity;
                mat.color = tempColor;

                //Debug.Log("tempColor.a___" + tempColor.a);
                opacity = opacity + (.08f * Time.deltaTime);
            
            }

            
            if (opacity <= .5 )
                {
                myLight.intensity = (opacity * 40);
                
            }
            else
            {
                myLight.intensity = (40 -(opacity * 40));
                
            }
        }

        //rigidbody.isKinematic = true

    }
}
