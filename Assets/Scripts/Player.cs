using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
      movments();
    }
    void movments(){
          if(Input.GetMouseButtonDown(1)){
            Ray movePos = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePos, out var hitInfo)){
                navMeshAgent.SetDestination(hitInfo.point);
                transform.LookAt(hitInfo.point);
               
            }
        }
    }
}