using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
            rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        movment();
    }
    void movment() {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        Vector3 _movment = new Vector3(_horizontal, 0.0f, _vertical);
        transform.Translate(_movment * speed * Time.deltaTime);
        if(_horizontal < 0){
            transform.Rotate(Vector3.up * 100f * Time.deltaTime);


        }





    }
}
