using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    ObjectFader _fader;
  

    void Update()
    {
       
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            
            Vector3 dir = player.transform.position - transform.position;
            Ray ray = new Ray(transform.position, dir);
            RaycastHit hit;
            Debug.DrawRay(transform.position, dir);
            
            if(Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject.name);
                if(hit.collider != null)
                return;
                if(hit.collider.gameObject == player)
                {
                    // Nothing is in front of the player
                    if(_fader != null)
                    {
                        print("B");
                        _fader.doFade = false;
                    }
                    else
                    {
                        
                        _fader = hit.collider.gameObject.GetComponent<ObjectFader>();
                        if(_fader != null)
                        {
                            _fader.doFade = true;
                        }
                    }
                }

            }        
        }


    }
}
