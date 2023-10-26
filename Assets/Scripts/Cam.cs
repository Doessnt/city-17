using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cam : MonoBehaviour
{
    private TransperntWall _fader;

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if(player!= null)
        {
            Vector3 pos = player.transform.position - transform.position;
            Ray ray = new Ray(transform.position, pos);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider == null) { return; }
                if (hit.collider.gameObject == player)
                {
                     if(_fader != null)
                    {
                        _fader.doFade = false;
                    }
                    else
                    {
                        _fader = hit.collider.gameObject.GetComponent<TransperntWall>();
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
