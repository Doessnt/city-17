using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransperntWall : MonoBehaviour
{
    [SerializeField] float fadeSpeed, fadeAmount;
    public bool doFade = false;
    float originOpacity;
    Material material;
    private void Start()
    {
        material = GetComponent<Renderer>().material;

        originOpacity = material.color.a;
    }
    private void Update()
    {
        if (doFade)
        {
            _doFade();
        }
        else
        {
            resetFade();
        }
    }
    void _doFade()
    {
        Color currentColor = material.color;
        Color smoothColor = new Color(currentColor.r, currentColor.g, currentColor.b, Mathf.Lerp(currentColor.a, fadeAmount, fadeSpeed * Time.deltaTime));
        material.color = smoothColor;
    }
    void resetFade()
    {
             
    }

}
