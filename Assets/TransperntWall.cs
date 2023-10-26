using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransperntWall : MonoBehaviour
{
    public GameObject Wall;
    public float alpha = 1f;
    private void Start() {
        Wall = gameObject;
    }
    private void Update() {
        changeAlpha(Wall.GetComponent<Renderer>().material, alpha);
    }
    void changeAlpha(Material mat, float alpha){
        Color oldcolor = mat.color;
        Color newcolor = new Color(oldcolor.r, oldcolor.g, oldcolor.b, alpha);
        mat.SetColor("_Color", newcolor);
    }

}
