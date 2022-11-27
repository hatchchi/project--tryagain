using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam2MeUp1 : MonoBehaviour
{
 float opacity;
 Color c;
    Material mat;
    Color tempColor;
    private Material[] allMaterials;
    List<Color> allColors = new List<Color>();
    

    void Start()
    {
        
        opacity = 0;
        
        mat = GetComponent<Renderer>().material;
        tempColor = mat.color;

        allMaterials = GetComponent<Renderer>().materials;
        for (int i = 0; i < allMaterials.Length; i++)
            allColors.Add(allMaterials[i].color);

        //Debug.Log("opacity" + GetComponent<Renderer>().material.color);

    }

    
    void Update()
    {
        
        if (opacity <= 1)
        {
            
            foreach (Material mat in allMaterials)
            {
                tempColor.a = opacity;
                mat.color = tempColor;

                Debug.Log("tempColor.a___" + tempColor.a);
                opacity = opacity + (.1f * Time.deltaTime);
            
            }

        }
    }
}
