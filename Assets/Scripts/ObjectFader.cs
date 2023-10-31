using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFader : MonoBehaviour
{
    public float fadeSpeed, fadeAmount;
    float defualtOpacity;
    public bool doFade = false;
    Material material;
    
    void Start()
    {
        material = GetComponent<Renderer>().material;
        defualtOpacity = material.color.a;
    }

    void Update()
    {
        if (doFade)
        {
            fadeNow();
        }
        else
        {
            resetFade();
        }
    }
    void fadeNow()
    {
        Color currentColor = material.color;
        Color smootColor = new Color(currentColor.r, currentColor.g, currentColor.b, Mathf.Lerp(currentColor.a, fadeAmount, fadeSpeed *Time.deltaTime));
        material.color = smootColor;
    }
    void resetFade()
    {
        Color currentColor = material.color;
        Color smootColor = new Color(currentColor.r, currentColor.g, currentColor.b, Mathf.Lerp(currentColor.a, defualtOpacity, fadeSpeed));
        material.color = smootColor;
    }
}
